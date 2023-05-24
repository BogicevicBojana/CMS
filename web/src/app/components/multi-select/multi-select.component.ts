import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-multi-select',
  templateUrl: './multi-select.component.html',
  styleUrls: ['./multi-select.component.scss'],
})
export class MultiSelectComponent implements OnInit {
  @Input() label: string = '';
  @Input() dataSource: any = [];
  @Input() propertyToDisplay: string = '';
  @Input() propertyToSelect: string = '';
  @Input() placeholder: string = '';
  @Input() required: boolean = false;
  @Input() hideValue: boolean = false;

  @Input() inputModel?: any[];
  @Output() inputModelChange = new EventEmitter<any[]>();

  countChanged: EventEmitter<any[]> = new EventEmitter();

  renderLabel?: Boolean = this.label !== null;

  constructor() {}

  ngOnInit(): void {}
}
