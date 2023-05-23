import { Component, OnInit } from '@angular/core';
import { ConfigurationType } from 'src/app/configuration.enum';
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
  userBenefits: any[] = [];
  selectedUserId?: number = 1;
  users: User[] = [];

  constructor(
    private userService: UserService,
    private configurationService: ConfigurationService
  ) {}

  ngOnInit(): void {
    this.loadAllBenefits();
    this.loadAllUsers();
    this.loadUserBenefits();
  }

  private loadAllUsers() {
    this.userService.getAllUsers().subscribe((response) => {
      this.users = response.data;
    });
  }

  private loadAllBenefits() {
    this.configurationService
      .getItems(ConfigurationType.BENEFIT)
      .subscribe((response) => (this.allBenefits = response.data));
  }

  private loadUserBenefits() {
    this.userBenefits = this.users.find(
      (user) => user.id === this.selectedUserId
    )?.benefits!;
  }

  userBenefitsMap: Map<Number, Boolean> = new Map();

  public isBenefitActive(benefit: any): Boolean {
    if (this.userBenefitsMap.has(benefit.id)) {
      return this.userBenefitsMap.get(benefit.id)!;
    }

    this.userBenefits?.forEach((currentUserBenefit) => {
      if (currentUserBenefit.id === benefit.id) {
        this.userBenefitsMap.set(benefit.id, true);
        return true;
      }

      this.userBenefitsMap.set(benefit.id, false);
      return false;
    });

    this.userBenefitsMap.set(benefit.id, false);
    return false;
  }

  public onClick(benefit: any) {
    this.userService.setBenefit(
      this.isBenefitActive(benefit),
      benefit.id,
      this.selectedUserId!
    );
  }

  public onUserChange() {
    this.userBenefitsMap.clear();
  }
}
