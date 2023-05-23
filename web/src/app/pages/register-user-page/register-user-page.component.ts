import { Component, OnInit } from '@angular/core';
import { ConfigurationType } from 'src/app/configuration.enum';
import { RegisterUserDTO } from 'src/app/data/RegisterUser.dto';
import { UserRoles } from 'src/app/data/UserRoles.contant';
import { ConfigurationService } from 'src/app/services/configuration.service';
import { NotificationService } from 'src/app/services/notification.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-register-user-page',
  templateUrl: './register-user-page.component.html',
  styleUrls: ['./register-user-page.component.scss'],
})
export class RegisterUserPageComponent implements OnInit {
  workingPositions: any = [];
  userRoles: any = [];

  userEmail!: string;
  userFirstName!: string;
  userLastName!: string;
  selectedDate!: Date;

  selectedWorkingPositionId!: number;
  selectedUserRoleId!: number;

  emailError?: string;
  employmentDateError?: string;
  workingPositionError?: string;
  userRoleError?: string;

  constructor(
    private configurationService: ConfigurationService,
    private userService: UserService,
    private notificationService: NotificationService
  ) {}

  ngOnInit(): void {
    this.getWorkingPositions();
    this.userRoles = UserRoles;
  }

  getWorkingPositions() {
    return this.configurationService
      .getItems(ConfigurationType.WORKING_POSITION)
      .subscribe(
        (workingPositions) => (this.workingPositions = workingPositions.data)
      );
  }

  registerUser() {
    this.resetErrorMessages();

    const user = this.createNewUser();

    if (
      !this.userEmail ||
      !this.userLastName ||
      !this.userFirstName ||
      !this.selectedDate ||
      !this.selectedWorkingPositionId
    ) {
      this.notificationService.showWarningMessage(
        'Invalid input',
        'Please fill out required data',
        4000
      );

      return;
    }

    if (new Date(this.selectedDate).getTime() > new Date().getTime()) {
      this.notificationService.showWarningMessage(
        'Invalid input',
        `Employment date can't be in future`,
        4000
      );

      return;
    }

    this.userService.registerUser(user).subscribe({
      error: (responseBody) =>
        this.handleError(responseBody.error.messages as String[]),
      next: (responseBody) => {
        this.notificationService.showSuccessMessageCheck(
          responseBody,
          'Success',
          'User registered successfully',
          4000
        );
        this.setInputDefaults();
      },
    });
  }

  private handleError(errorsArray: String[]) {
    if (!errorsArray) {
      this.notificationService.showErrorMessage(
        'Internal server error',
        'An unexpected error has occurred. Please try again later.',
        4000
      );

      return;
    }

    if (!this.selectedDate) {
      this.employmentDateError = 'Employment date is required';
    }

    this.setErrorMessages(errorsArray);

    this.notificationService.showWarningMessage(
      'Invalid input',
      'Please review validation errors and provide valid data',
      4000
    );
  }

  private setErrorMessages(errorsArray: String[]) {
    const setErrorMessage = (error: String) => {
      return error.substring(error.indexOf(':') + 1).trim();
    };

    errorsArray.forEach((error) => {
      let statusCode: string = error.substring(0, error.indexOf(':') - 1);

      if (
        statusCode.includes('Email') ||
        statusCode.includes('AlreadyExists')
      ) {
        this.emailError = setErrorMessage(error);
      }

      if (statusCode.includes('Date')) {
        this.employmentDateError = setErrorMessage(error);
      }

      if (statusCode.includes('Working')) {
        this.workingPositionError = setErrorMessage(error);
      }

      if (statusCode.includes('Role')) {
        this.userRoleError = setErrorMessage(error);
      }
    });
  }

  private createNewUser() {
    const user = new RegisterUserDTO(
      this.userFirstName,
      this.userLastName,
      this.userEmail,
      this.selectedDate,
      this.selectedWorkingPositionId,
      this.selectedUserRoleId
    );
    return user;
  }

  private resetErrorMessages() {
    this.emailError = '';
    this.workingPositionError = '';
    this.userRoleError = '';
    this.employmentDateError = '';
  }

  private setInputDefaults() {
    this.userEmail = '';
    this.selectedDate = new Date('0001-01-01');
    this.selectedUserRoleId = 0;
    this.selectedWorkingPositionId = 0;
  }
}
