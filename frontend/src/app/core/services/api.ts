import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private baseUrl = 'https://localhost:7100/api';

  constructor(private http: HttpClient) {}

  getHealth() {
    return this.http.get(`${this.baseUrl}/health`);
  }
}