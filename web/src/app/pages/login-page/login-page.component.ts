import { Component, NgZone, OnInit } from '@angular/core';
import { AuthService } from 'src/app/services/auth.service';
import { CredentialResponse, PromptMomentNotification } from 'google-one-tap';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.scss'],
})
export class LoginPageComponent implements OnInit {
  constructor(private authService: AuthService, private router: Router, private _ngZone: NgZone) { }

  ngOnInit(): void {
    // @ts-ignore
    window.onGoogleLibraryLoad = () => {
      // @ts-ignore
      google.accounts.id.initialize({
        client_id: environment.googleClientId,
        callback: this.handleGoogleResponse.bind(this),
        auto_select: false,
        cancel_on_tap_outside: true,
        ux_mode: 'popup',
      });

      // @ts-ignore
      google.accounts.id.renderButton(
        // @ts-ignore
        document.getElementById("buttonDiv"),
        { theme: 'outline', size: "large", width: "100%" }
      );
      // @ts-ignore
      google.accounts.id.prompt((notification: PromptMomentNotification) => { });
    }
  }

  handleGoogleResponse(response: CredentialResponse) {
    this.authService.loginWithGoogle(response.credential);
  }
}
