import {
  Component,
  OnInit,
  ViewChild,
  ViewChildren,
  ViewContainerRef,
} from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { ConfigurationType } from 'src/app/configuration.enum';
import { AddConfigurationItemDTO } from 'src/app/data/AddConfigurationItemDTO.model';
import { ConfigurationItem } from 'src/app/data/ConfigurationItem.model';
import { ConfigurationService } from 'src/app/services/configuration.service';
import { ModalService } from 'src/app/services/modal.service';
import { NotificationService } from 'src/app/services/notification.service';

@Component({
  selector: 'app-configuration-page',
  templateUrl: './configuration-page.component.html',
  styleUrls: ['./configuration-page.component.scss'],
})
export class ConfigurationPageComponent implements OnInit {
  constructor(
    private configurationService: ConfigurationService,
    private toastr: ToastrService,
    private modalService: ModalService,
    private notificationService: NotificationService
  ) {}

  @ViewChild('modal', { read: ViewContainerRef })
  entry!: ViewContainerRef;
  sub!: Subscription;

  benefits: ConfigurationItem[] = [];
  skills: ConfigurationItem[] = [];
  workingPositions: ConfigurationItem[] = [];
  languages: ConfigurationItem[] = [];

  selectedTypeId: number = 0;

  configurationItemTypes: ConfigurationItem[] = [
    new ConfigurationItem(0, ConfigurationType.LANGUAGE),
    new ConfigurationItem(1, ConfigurationType.SKILL),
    new ConfigurationItem(2, ConfigurationType.BENEFIT),
    new ConfigurationItem(3, ConfigurationType.WORKING_POSITION),
  ];

  configurationItemTypesMap: Map<number, ConfigurationType> = new Map<
    number,
    ConfigurationType
  >([
    [0, ConfigurationType.LANGUAGE],
    [1, ConfigurationType.SKILL],
    [2, ConfigurationType.BENEFIT],
    [3, ConfigurationType.WORKING_POSITION],
  ]);

  itemName: string = '';
  itemType?: ConfigurationType;

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

  reloadItem(itemType: ConfigurationType, operation: string = 'deleted') {
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
        this.toastr.success(
          `${itemType} successfully ${operation}!`,
          'Success',
          {
            progressBar: true,
          }
        ),
    });
  }

  openModal(modalId: number) {
    this.modalService.open(modalId);
  }

  addItem() {
    const type: ConfigurationType = this.configurationItemTypesMap.get(
      this.selectedTypeId
    )!;
    const item = new AddConfigurationItemDTO(this.itemName, type);

    if (this.itemName) {
      this.configurationService.addItem(item).subscribe(() => {
        this.reloadItem(type, 'added');
        this.itemName = '';
      });

      this.modalService.close(0);
    } else {
      this.notificationService.showWarningMessage(
        'Invalid input',
        `Item name can't be empty`,
        4000
      );
    }
  }
}
