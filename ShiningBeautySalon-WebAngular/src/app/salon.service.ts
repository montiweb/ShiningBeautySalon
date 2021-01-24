import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SalonService {

  constructor(private http: HttpClient) { }

  get(): Observable<any[]> {
    return this.http.get<any[]>(`http://api.shiningbeautysalon.com/Salon`);
    //return this.http.get<any[]>(`https://localhost:44355/Salon`);
  }
}
