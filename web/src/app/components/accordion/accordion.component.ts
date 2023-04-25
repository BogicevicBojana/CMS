import { Component, Input } from '@angular/core';
import { ConfigurationType } from 'src/app/configuration.enum';

@Component({
  selector: 'app-accordion',
  templateUrl: './accordion.component.html',
  styleUrls: ['./accordion.component.scss'],
})
export class AccordionComponent {
  @Input() title: String = '';
  @Input() items: any[] = [];
  @Input() openedByDefault: boolean = false;
  @Input() configurationItemType: ConfigurationType | undefined;

  expanded: boolean = false;

  ngOnInit(): void {
    this.expanded = this.openedByDefault;
  }

  onClick(): void {
    this.expanded = !this.expanded;
  }
}
