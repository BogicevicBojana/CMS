import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ConfigurationType } from 'src/app/configuration.enum';
import { ConfigurationItem } from 'src/app/data/ConfigurationItem.model';
import { UpdateUserDTO } from 'src/app/data/UpdateUserDTO.model';
import { User } from 'src/app/data/User.model';
import { AuthService } from 'src/app/services/auth.service';
import { ConfigurationService } from 'src/app/services/configuration.service';
import { NotificationService } from 'src/app/services/notification.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-profile-page',
  templateUrl: './user-profile-page.component.html',
  styleUrls: ['./user-profile-page.component.scss'],
})
export class UserProfilePageComponent implements OnInit {
  imageUrl?: string = './assets/images/default_avatar.png';
  user?: User;

  userId: number = 0;

  allWorkingPosition: ConfigurationItem[] = [];
  currentWorkingPositionId?: number;

  allLanguages: ConfigurationItem[] = [];
  userLanguages: any[] = []; // ids only

  allSkills: ConfigurationItem[] = [];
  userSkills: any[] = []; // ids only

  newFirstName!: string;
  newLastName!: string;
  newEmail!: string;
  newAddress!: string;
  newPhoneNumber!: string;
  newDateOfBirth!: string;
  newEmploymentDate!: string;

  constructor(
    private route: ActivatedRoute,
    private userService: UserService,
    private configurationService: ConfigurationService,
    private notificationService: NotificationService
  ) {}

  ngOnInit(): void {
    this.userId = Number(this.route.snapshot.paramMap.get('id'));
    this.getUser();
    this.getAllWorkingPositions();
    this.getAllSkills();
    this.getAllLanguages();
  }

  private getUser() {
    this.userService.getUser(this.userId).subscribe((response) => {
      this.user = response.data;
      this.userLanguages = this.user?.languages!.map((l) => l.id)!;
      this.userSkills = this.user?.skills!.map((skill) => skill.id)!;
      this.currentWorkingPositionId = this.user?.working_position.id;

      this.newFirstName = this.user?.first_name!;
      this.newLastName = this.user?.last_name!;
      this.newEmail = this.user?.email!;
      this.newAddress = this.user?.address!;
      this.newEmploymentDate = this.user?.employment_date!;
      this.newDateOfBirth = this.user?.date_of_birth!;
      this.newPhoneNumber = this.user?.mobile_number!;
    });
  }

  private getAllWorkingPositions() {
    this.configurationService
      .getItems(ConfigurationType.WORKING_POSITION)
      .subscribe((response) => (this.allWorkingPosition = response.data));
  }

  private getAllLanguages() {
    this.configurationService
      .getItems(ConfigurationType.LANGUAGE)
      .subscribe((response) => (this.allLanguages = response.data));
  }

  private getAllSkills() {
    this.configurationService
      .getItems(ConfigurationType.SKILL)
      .subscribe((response) => (this.allSkills = response.data));
  }

  getPlaceholder(inputArray: any[]): string {
    if (this.userLanguages.length > 0) {
      let placeholder: string = '';
      inputArray.forEach((skill) => (placeholder += skill.name + ', '));

      placeholder = placeholder.slice(0, -2);

      if (placeholder.length >= 32) {
        placeholder = `${placeholder.slice(0, 32)}...`;
      }

      return placeholder;
    } else {
      return 'No languages selected';
    }
  }

  deleteProfile() {
    if (this.user?.user_status.id === 2) return;

    this.userService.deleteUser(this.userId).subscribe({
      complete: () => {
        this.notificationService.showSuccessMessage(
          'Success',
          'User profile is deactivated',
          4000
        );
      },
    });
  }

  updateProfile() {
    if (this.user?.user_status.id === 2) return;

    const updatedUser: UpdateUserDTO = {
      id: this.user?.id!,
      first_name: this.newFirstName,
      last_name: this.newLastName,
      date_of_birth: this.newDateOfBirth,
      working_position_id: this.currentWorkingPositionId!,
      role_id: this.user?.role.id!,
      languages: this.userLanguages,
      skills: this.userSkills,
      employment_date: this.newEmploymentDate,
      email: this.newEmail,
      address: this.newAddress,
      mobile_number: this.newPhoneNumber,
      religious_holidays: this.user?.religious_holidays!,
    };

    this.userService.updateUser(updatedUser).subscribe({
      error: (response) => {
        this.notificationService.showErrorMessageTopRight(
          'Error occured',
          'Make sure all fields have value',
          4000
        );
      },
      next: () => {
        this.getUser();
        this.notificationService.showSuccessMessage(
          'Changes saved!',
          'User updated successfully',
          4000
        );
      },
    });
  }
}
