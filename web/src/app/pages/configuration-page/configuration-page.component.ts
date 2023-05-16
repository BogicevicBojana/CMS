import { Component, OnInit } from '@angular/core';
import { ConfigurationType } from 'src/app/configuration.enum';
import { ConfigurationItem } from 'src/app/data/ConfigurationItem.model';
import { ConfigurationService } from 'src/app/services/configuration.service';

@Component({
  selector: 'app-configuration-page',
  templateUrl: './configuration-page.component.html',
  styleUrls: ['./configuration-page.component.scss'],
})
export class ConfigurationPageComponent implements OnInit {
  constructor(private configurationService: ConfigurationService) {}

  benefits: ConfigurationItem[] = [];
  skills: ConfigurationItem[] = [];
  workingPositions: ConfigurationItem[] = [];
  languages: ConfigurationItem[] = [];

  public get configurationType(): typeof ConfigurationType {
    return ConfigurationType;
  }

  ngOnInit(): void {
    this.getBenefits();
  }

  getBenefits() {
    this.configurationService
      .getItems(ConfigurationType.BENEFIT)
      .subscribe((data) => (this.benefits = data));
  }

  getSkills() {
    this.configurationService
      .getItems(ConfigurationType.SKILL)
      .subscribe((data) => (this.skills = data));
  }

  getLanguages() {
    this.configurationService
      .getItems(ConfigurationType.LANGUAGE)
      .subscribe((data) => (this.languages = data));
  }

  getWorkingPositions() {
    this.configurationService
      .getItems(ConfigurationType.WORKING_POSITION)
      .subscribe((data) => (this.workingPositions = data));
  }
}
