import { Component, NgZone, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {
  logoutIcon: string = 'assets/icons/logout-icon.svg';
  registerUserIcon: string = 'assets/icons/plus-icon.svg';
  hidden: boolean = true;

  constructor(public router: Router, public service: AuthService, private _ngZone: NgZone) { }

  ngOnInit(): void {
    this.hidden = false;
  }

  logout(): void {
    // this.service.signOutExternal();
    // this._ngZone.run(() => {
    //   this.router.navigate(['/']).then(() => window.location.reload());
    // })
  }
}
