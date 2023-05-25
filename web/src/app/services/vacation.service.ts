import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class VacationService {
  private baseUrl: string = `http://localhost:${environment.port}/vacation`;

  private httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
  };

  constructor(private http: HttpClient) {}

  getAllVacations(): Observable<any> {
    const endpoint = `${this.baseUrl}/information`;
    return this.http.get<any>(endpoint, this.httpOptions);
  }

  addVacation(vacation: InsertVacation): Observable<any> {
    const endpoint = `${this.baseUrl}/insertion`;
    return this.http.post(endpoint, vacation);
  }

  deleteVacation(vacationId: number): Observable<any> {
    const endpoint = `${this.baseUrl}/deletion/${vacationId}`;
    return this.http.delete(endpoint, this.httpOptions);
  }
}

export interface InsertVacation {
  start_date: Date;
  end_date: Date;
  user_id: number;
}
