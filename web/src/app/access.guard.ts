import { Injectable } from '@angular/core';
import {
  ActivatedRouteSnapshot,
  CanActivate,
  Router,
  RouterStateSnapshot,
  UrlTree,
} from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from './services/auth.service';

@Injectable({
  providedIn: 'root',
})
export class AccessGuard implements CanActivate {
  constructor(private authService: AuthService, private router: Router) {}

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ):
    | Observable<boolean | UrlTree>
    | Promise<boolean | UrlTree>
    | boolean
    | UrlTree {
    // route metadata
    const requiresLoginRoute = route.data['requiresLogin'];

    // user status
    const isUserLoggedIn = this.authService.isUserLoggedIn();

    if (!isUserLoggedIn && requiresLoginRoute) {
      this.router.navigate(['login']);
      return false;
    }

    if (requiresLoginRoute) {
      return isUserLoggedIn;
    }

    return false;
  }
}
