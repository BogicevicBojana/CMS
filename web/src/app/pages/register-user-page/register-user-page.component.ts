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

  selectedWorkingPositionId!: number | undefined;
  selectedUserRoleId!: number | undefined;

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
    const user = this.createNewUser();

    if (
      !this.userEmail ||
      !this.userLastName ||
      !this.userFirstName ||
      !this.selectedDate ||
      !this.selectedWorkingPositionId ||
      !this.selectedUserRoleId
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
      error: (responseBody) => {
        this.notificationService.showErrorMessageTopRight(
          'Error occured',
          responseBody.error.message || 'Internal server error',
          4000
        );
      },
      next: () => {
        this.notificationService.showSuccessMessage(
          'Success',
          'User registered successfully',
          4000
        );
        this.setInputDefaults();
      },
    });
  }

  createNewUser = () =>
    new RegisterUserDTO(
      this.userFirstName,
      this.userLastName,
      this.userEmail,
      this.selectedDate,
      this.selectedWorkingPositionId!,
      this.selectedUserRoleId!
    );

  private setInputDefaults() {
    this.userFirstName = '';
    this.userLastName = '';
    this.userEmail = '';
    this.selectedDate = new Date('0001-01-01');
    this.selectedUserRoleId = undefined;
    this.selectedWorkingPositionId = undefined;
  }
}
