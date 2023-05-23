import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-single-select',
  templateUrl: './single-select.component.html',
  styleUrls: ['./single-select.component.scss'],
})
export class SingleSelectComponent implements OnInit {
  @Input() label: string = '';
  @Input() dataSource: any = [];
  @Input() propertyToDisplay: string = '';
  @Input() propertyToSelect: string = '';
  @Input() placeholder: string = '';
  @Input() required: boolean = false;

  @Input() inputModel?: number;
  @Output() inputModelChange = new EventEmitter<number>();

  countChanged: EventEmitter<number> = new EventEmitter();

  renderLabel?: Boolean = this.label !== null;

  constructor() {}

  ngOnInit(): void {}
}
