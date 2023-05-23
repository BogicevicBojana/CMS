import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RegisterUserDTO } from '../data/RegisterUser.dto';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  baseUrl: string = `http://localhost:${environment.port}/user`;

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
  };

  constructor(private http: HttpClient) {}

  registerUser(user: RegisterUserDTO): Observable<RegisterUserDTO> {
    const endpoint: string = `${this.baseUrl}/insertion`;
    return this.http.post<RegisterUserDTO>(endpoint, user, this.httpOptions);
  }
}
