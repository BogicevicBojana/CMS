import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map, of } from 'rxjs';
import { RegisterUserDTO } from '../data/RegisterUser.dto';
import { environment } from 'src/environments/environment';
import { User } from '../data/User.model';
import { UpdateUserDTO } from '../data/UpdateUserDTO.model';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private baseUrl: string = `http://localhost:${environment.port}/user`;

  private httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
  };

  constructor(private http: HttpClient) {}

  registerUser(user: RegisterUserDTO): Observable<RegisterUserDTO> {
    const endpoint: string = `${this.baseUrl}/insertion`;
    return this.http.post<RegisterUserDTO>(endpoint, user, this.httpOptions);
  }

  getUser(id: Number): Observable<any> {
    const endpoint: string = `${this.baseUrl}/information/${id}`;
    return this.http.get<any>(endpoint, this.httpOptions);
  }

  getAllUsers(): Observable<any> {
    const endpoint: string = `${this.baseUrl}/information`;
    return this.http.get<any>(endpoint, this.httpOptions);
  }

  setBenefit(isEnabled: Boolean, benefitId: Number, userId: Number) {
    const endpoint: string = `${this.baseUrl}/update/benefit/${isEnabled}`;
    return this.http.put(
      endpoint,
      { user_id: userId, benefit_id: benefitId },
      this.httpOptions
    );
  }

  updateUser(user: UpdateUserDTO): Observable<any> {
    const endpoint: string = `${this.baseUrl}/update`;
    return this.http.put(endpoint, user, this.httpOptions);
  }
}
