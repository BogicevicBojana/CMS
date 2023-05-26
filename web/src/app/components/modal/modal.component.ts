import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Observable } from 'rxjs';
import { ModalService } from 'src/app/services/modal.service';

@Component({
  selector: 'app-modal',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.scss'],
})
export class ModalComponent {
  display$: Observable<'open' | 'close'> | undefined;

  @Input() modalId?: number;

  constructor(private modalService: ModalService) {}

  ngOnInit() {
    this.display$ = this.modalService.watch(this.modalId!);
  }

  close() {
    this.modalService.close(this.modalId!);
  }
}
