import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { observable, Observable } from 'rxjs';
import { ConfigurationItem } from '../data/ConfigurationItem.model';
import { AddConfigurationItemDTO } from '../data/AddConfigurationItemDTO.model';
import { CustomHttpResponse } from '../data/CustomHttpResponse.model';

@Injectable({
  providedIn: 'root',
})
export class ConfigurationService {
  constructor(private http: HttpClient) {}

  baseUrl: string = 'http://localhost:5173/configuration/';

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
  };

  getItems(type: string): Observable<any> {
    return this.http.get<any>(this.baseUrl + `information/${type}`);
  }

  deleteItem(type: String, item: ConfigurationItem): Observable<any> {
    const url: string = `${this.baseUrl}deletion/${type}/${item.id}`;
    return this.http.delete<any>(url);
  }

  /* POST http://localhost:5000/configuration
      {
        type: string
        name: string
      }
  */
  addItem(item: AddConfigurationItemDTO): Observable<CustomHttpResponse> {
    return this.http.post<CustomHttpResponse>(
      this.baseUrl,
      item,
      this.httpOptions
    );
  }
}
