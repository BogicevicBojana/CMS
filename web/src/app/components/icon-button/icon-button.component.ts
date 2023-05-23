import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-icon-button',
  templateUrl: './icon-button.component.html',
  styleUrls: ['./icon-button.component.scss'],
})
export class IconButtonComponent {
  @Input() buttonText: string = '';
  @Input() isDisabled = false;
  @Input() showIcon = false;
  @Input() iconPath: string = 'assets/icons/plus-icon.svg';
  @Input() styleClass?: string = '';

  @Output() btnClick = new EventEmitter();

  constructor() {}

  ngOnInit(): void {}

  onClick() {
    this.btnClick.emit();
  }
}
