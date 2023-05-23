import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root',
})
export class NotificationService {
  constructor(public toastrService: ToastrService) {}

  showErrorMessage(title: string, message: string, timeOut: number): void {
    this.toastrService.error(message, title, {
      timeOut: timeOut,
      progressBar: true,
      positionClass: 'toast-bottom-center',
    });
  }

  showWarningMessage(title: string, message: string, timeOut: number): void {
    this.toastrService.warning(message, title, {
      timeOut: timeOut,
      progressBar: true,
    });
  }

  showSuccessMessageCheck(
    responseBody: any,
    title: string,
    message: string,
    timeOut: number
  ): void {
    if (responseBody.succeeded) {
      this.toastrService.success(message, title, {
        timeOut: timeOut,
        progressBar: true,
      });
    }
  }

  showSuccessMessage(title: string, message: string, timeOut: number): void {
    this.toastrService.success(message, title, {
      timeOut: timeOut,
      progressBar: true,
    });
  }
}
