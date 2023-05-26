import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ModalService {
  private modalStates: BehaviorSubject<'open' | 'close'>[] = [
    new BehaviorSubject<'open' | 'close'>('close'),
    new BehaviorSubject<'open' | 'close'>('close'),
  ];

  watch(modalId: number): Observable<'open' | 'close'> {
    return this.modalStates[modalId].asObservable();
  }

  open(modalId: number) {
    this.modalStates[modalId].next('open');
  }

  close(modalId: number) {
    this.modalStates[modalId].next('close');
  }
}
