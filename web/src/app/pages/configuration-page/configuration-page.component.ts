import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ConfigurationType } from 'src/app/configuration.enum';
import { ConfigurationItem } from 'src/app/data/ConfigurationItem.model';
import { ConfigurationService } from 'src/app/services/configuration.service';

@Component({
  selector: 'app-configuration-page',
  templateUrl: './configuration-page.component.html',
  styleUrls: ['./configuration-page.component.scss'],
})
export class ConfigurationPageComponent implements OnInit {
  constructor(
    private configurationService: ConfigurationService,
    private toastr: ToastrService
  ) {}

  benefits: ConfigurationItem[] = [];
  skills: ConfigurationItem[] = [];
  workingPositions: ConfigurationItem[] = [];
  languages: ConfigurationItem[] = [];

  public get configurationType(): typeof ConfigurationType {
    return ConfigurationType;
  }

  ngOnInit(): void {
    this.getBenefits();
    this.getLanguages();
    this.getSkills();
    this.getWorkingPositions();
  }

  getBenefits() {
    this.configurationService
      .getItems(ConfigurationType.BENEFIT)
      .subscribe((response) => (this.benefits = response.data));
  }

  getSkills() {
    this.configurationService
      .getItems(ConfigurationType.SKILL)
      .subscribe((data) => (this.skills = data.data));
  }

  getLanguages() {
    this.configurationService
      .getItems(ConfigurationType.LANGUAGE)
      .subscribe((data) => (this.languages = data.data));
  }

  getWorkingPositions() {
    this.configurationService
      .getItems(ConfigurationType.WORKING_POSITION)
      .subscribe((data) => (this.workingPositions = data.data));
  }

  reloadItem(itemType: ConfigurationType) {
    this.configurationService.getItems(itemType).subscribe({
      next: (response) => {
        switch (itemType) {
          case ConfigurationType.LANGUAGE:
            this.languages = response.data;
            break;
          case ConfigurationType.BENEFIT:
            this.benefits = response.data;
            break;
          case ConfigurationType.WORKING_POSITION:
            this.workingPositions = response.data;
            break;
          case ConfigurationType.SKILL:
            this.skills = response.data;
            break;
          default:
            break;
        }
      },
      complete: () =>
        this.toastr.success(`${itemType} successfully deleted!`, 'Success', {
          progressBar: true,
        }),
    });
  }
}
