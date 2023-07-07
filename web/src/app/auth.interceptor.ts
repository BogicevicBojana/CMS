import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HTTP_INTERCEPTORS,
  HttpContextToken,
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { AuthService } from './services/auth.service';
export const BYPASS_AUTH = new HttpContextToken(() => false);

@Injectable()
export class AuthInterceptor implements HttpInterceptor {
  constructor(private authService: AuthService) {}

  // set authorization header on every http request except the ones with BYPASS_LOG set to true

  intercept(
    request: HttpRequest<unknown>,
    next: HttpHandler
  ): Observable<HttpEvent<unknown>> {
    if (request.context.get(BYPASS_AUTH) === true) {
      return next.handle(request);
    }

    request = request.clone({
      headers: request.headers.set(
        'authorization',
        'bearer ' + this.authService.getToken()
      ),
    });

    return next.handle(request);
  }
}

export const AuthInterceptorProvider = {
  provide: HTTP_INTERCEPTORS,
  useClass: AuthInterceptor,
  multi: true,
};
