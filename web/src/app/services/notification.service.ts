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

  showErrorMessageTopRight(
    title: string,
    message: string,
    timeOut: number
  ): void {
    this.toastrService.error(message, title, {
      timeOut: timeOut,
      progressBar: true,
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
    if (responseBody.code >= 200 && responseBody.code <= 299) {
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
