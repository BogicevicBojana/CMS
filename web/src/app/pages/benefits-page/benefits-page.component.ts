import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { ConfigurationType } from 'src/app/configuration.enum';
import { ConfigurationItem } from 'src/app/data/ConfigurationItem.model';
import { User } from 'src/app/data/User.model';
import { ConfigurationService } from 'src/app/services/configuration.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-benefits-page',
  templateUrl: './benefits-page.component.html',
  styleUrls: ['./benefits-page.component.scss'],
})
export default class BenefitsPageComponent implements OnInit {
  allBenefits: any[] = [];
  userBenefits: ConfigurationItem[] = [];

  selectedUserId?: number = 1;
  users: User[] = [];

  constructor(
    private cdref: ChangeDetectorRef,
    private userService: UserService,
    private configurationService: ConfigurationService
  ) {}

  ngOnInit(): void {
    this.loadAllBenefits();
  }

  private loadAllUsers() {
    this.userService.getAllUsers().subscribe((response) => {
      this.users = response.data;
      this.loadUserBenefits();
    });
  }

  private loadAllBenefits() {
    this.configurationService.getItems(ConfigurationType.BENEFIT).subscribe({
      next: (response) => (this.allBenefits = response.data),
      complete: () => {
        this.loadAllUsers();
      },
    });
  }

  private loadUserBenefits() {
    this.userBenefits = this.users.find(
      (user) => user.id === this.selectedUserId
    )?.benefits!;
  }

  public isBenefitActive(benefit: any): Boolean {
    for (let index = 0; index < this.userBenefits.length; index++) {
      const currentUserBenefit = this.userBenefits[index];

      if (currentUserBenefit.id === benefit.id) {
        return true;
      }
    }
    return false;
  }

  public onClick(benefit: any) {
    this.userService
      .setBenefit(
        !this.isBenefitActive(benefit),
        benefit.id,
        this.selectedUserId!
      )
      .subscribe(() => this.loadAllBenefits());
  }

  public onUserChange() {
    this.loadUserBenefits();
  }
}
