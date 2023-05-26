import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable, NgZone } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, of } from 'rxjs';
import jwt_decode from 'jwt-decode';
import { AuthUser } from '../data/AuthUser.model';
import { NotificationService } from './notification.service';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(
    private notificationService: NotificationService,
    private httpClient: HttpClient,
    private router: Router,
    private _ngZone: NgZone
  ) {}

  private readonly TOKEN_NAME = 'token';
  header = new HttpHeaders({ 'Content-Type': 'application/json' });

  loginWithGoogle(googleToken: string) {
    this.authenticateUser(googleToken).subscribe({
      error: (responseBody) => {
        this.notificationService.showErrorMessage(
          'User not registered',
          "This account isn't registered on the system",
          5000
        );
      },

      next: (authToken) => {
        const user: { name: string; picture: string } = jwt_decode(googleToken);

        localStorage.setItem('profile_img_url', user.picture);
        localStorage.setItem('user_name', user.name),
          localStorage.setItem(this.TOKEN_NAME, authToken);
      },

      complete: () => {
        const isAdmin = this.isUserAdmin();

        if (isAdmin) {
          this._ngZone.run(() => {
            this.router.navigate(['app/users']);
          });
        } else {
          this.router.navigate(['app/my-profile']);
        }
      },
    });
  }

  public authenticateUser(IdToken: any): Observable<string> {
    return this.httpClient.post<string>(
      'http://localhost:5173/account/authenticate',
      {
        id_token: IdToken,
      },
      {
        headers: this.header,
        responseType: 'text' as 'json',
      }
    );
  }

  public signOut() {
    localStorage.clear();

    this._ngZone.run(() => {
      this.router.navigate(['/login']).then(() => window.location.reload());
    });
  }

  private decodeJWT(token: string): any {
    let data = '';

    if (token) {
      try {
        data = jwt_decode(token);
      } catch (error) {
        console.log(error);
      }
    }

    return data;
  }

  public isUserAdmin(): boolean {
    const userDecoded = this.decodeJWT(this.getToken());
    return userDecoded.role === 'Administrator';
  }

  public isUserLoggedIn(): boolean {
    return localStorage.getItem(this.TOKEN_NAME) !== null;
  }

  // get database id of currently logged in user
  public getUserId() {
    const userDecoded = this.decodeJWT(this.getToken());
    return of(userDecoded.nameid);
  }

  public getUser(): AuthUser {
    const userDecoded = this.decodeJWT(this.getToken());

    return new AuthUser(
      userDecoded.nameid,
      userDecoded.name,
      userDecoded.WorkingPosition,
      userDecoded.role
    );
  }

  public getToken(): string {
    return String(localStorage.getItem(this.TOKEN_NAME));
  }
}
