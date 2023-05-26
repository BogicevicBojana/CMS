import { ChangeDetectorRef, Component } from '@angular/core';
import { User, Vacation } from 'src/app/data/User.model';
import { ConfigurationService } from 'src/app/services/configuration.service';
import { NotificationService } from 'src/app/services/notification.service';
import { UserService } from 'src/app/services/user.service';
import {
  InsertVacation,
  VacationService,
} from 'src/app/services/vacation.service';

@Component({
  selector: 'app-vacations-page',
  templateUrl: './vacations-page.component.html',
  styleUrls: ['./vacations-page.component.scss'],
})
export class VacationsPageComponent {
  selectedUserId?: number = 1;
  users: User[] = [];
  user!: User;
  userVacations: Vacation[] = [];
  allVacations: GlobalVacation[] = [];

  startDate?: Date;
  endDate?: Date;

  p1: number = 1;
  p2: number = 1;

  constructor(
    private userService: UserService,
    private vacationService: VacationService,
    private notificationService: NotificationService
  ) {}

  ngOnInit(): void {
    this.loadAllUsers();
    this.loadAllVacations();
    this.loadUserVacations();
  }

  // loadsonly active users
  private loadAllUsers() {
    this.userService.getAllUsers().subscribe((response) => {
      this.users = response.data;
      this.users = this.users.filter((u) => u.user_status.id == 1);
    });
  }

  private loadAllVacations() {
    this.vacationService.getAllVacations().subscribe((response) => {
      this.allVacations = response.data;

      this.allVacations.sort((a, b) =>
        a.start_date > b.start_date ? 1 : b.start_date > a.start_date ? -1 : 0
      );
    });
  }

  private loadUserVacations() {
    this.userService.getUser(this.selectedUserId!).subscribe((response) => {
      this.user = response.data;
      this.userVacations = this.user.vacations;
    });
  }

  deleteVacation(vacationId: number) {
    this.vacationService.deleteVacation(vacationId).subscribe({
      next: () => {
        this.loadUserVacations();
        this.loadAllVacations();
      },
      complete: () => {
        this.notificationService.showSuccessMessage(
          'Success',
          'Vacation deleted successfully',
          4000
        );
      },
    });
  }

  addVacation() {
    if (!this.startDate || !this.endDate) {
      this.notificationService.showWarningMessage(
        'Invalid input',
        'Make sure start date and end date are selected and valid.',
        4000
      );

      return;
    }

    const vacation: InsertVacation = {
      start_date: this.startDate!,
      end_date: this.endDate!,
      user_id: this.selectedUserId!,
    };

    this.vacationService.addVacation(vacation).subscribe({
      error: (response) => {
        this.notificationService.showWarningMessage(
          'Error occured',
          response.error.message + '.',
          4000
        );
      },
      next: () => {
        this.loadUserVacations();
        this.loadAllVacations();
      },
      complete: () => {
        this.notificationService.showSuccessMessage(
          'Success',
          'Vacation successfully added!',
          4000
        );
      },
    });
  }

  onUserChange() {
    this.loadUserVacations();
  }
}

export interface GlobalVacation {
  id: number;
  start_date: Date;
  end_date: Date;
  user: UserBase;
}

export interface UserBase {
  id: number;
  first_name: string;
  last_name: string;
  full_name: string;
}
