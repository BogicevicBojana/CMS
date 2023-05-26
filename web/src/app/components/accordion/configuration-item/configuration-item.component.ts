import { Component, EventEmitter, Input, Output } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
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

  @Output() deleteItemEvent = new EventEmitter<any>();

  constructor(
    private configurationService: ConfigurationService,
    private toastr: ToastrService
  ) {}

  deleteItem(item: ConfigurationItem) {
    this.configurationService
      .deleteItem(this.type, item)
      .subscribe({ next: () => this.deleteItemEvent.emit() });
  }
}
