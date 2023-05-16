import { Component, Input } from '@angular/core';
import { ConfigurationType } from 'src/app/configuration.enum';
import { ConfigurationItem } from 'src/app/data/ConfigurationItem.model';
import { ConfigurationService } from 'src/app/services/configuration.service';

@Component({
  selector: 'app-configuration-item',
  templateUrl: './configuration-item.component.html',
  styleUrls: ['./configuration-item.component.scss'],
})
export class ConfigurationItemComponent {
  @Input() item: any;
  @Input() type!: ConfigurationType;

  constructor(private configurationService: ConfigurationService) {}

  deleteItem(item: ConfigurationItem) {
    // this.configurationService.deleteItem(this.type, item);
  }
}
