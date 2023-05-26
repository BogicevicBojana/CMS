import { Component, OnInit, ViewChild } from '@angular/core';
import { Toast, ToastContainerDirective, ToastrService } from 'ngx-toastr';
import { NotificationService } from './services/notification.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  @ViewChild(ToastContainerDirective, { static: true })
  toastContainer!: ToastContainerDirective;

  constructor(private notificationService: NotificationService) {}

  ngOnInit(): void {
    this.notificationService.toastrService.overlayContainer =
      this.toastContainer;
  }
}
