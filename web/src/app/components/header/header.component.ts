import { Component, NgZone, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {
  hidden: boolean = true;
  name: string = 'User name';

  constructor(
    public router: Router,
    public service: AuthService,
    private _ngZone: NgZone
  ) {}

  ngOnInit(): void {
    this.hidden = false;
    this.name = String(localStorage.getItem('user_name')).split(' ')[0];
  }

  logout(): void {
    this.service.signOut();
    this._ngZone.run(() => {
      this.router.navigate(['/']).then(() => window.location.reload());
    });
  }
}
