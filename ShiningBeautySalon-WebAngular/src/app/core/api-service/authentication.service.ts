import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http: HttpClient) { }



  login(username: string, password: string): Observable<any> {
 
    //return this.http.post<any>(`https://localhost:44355/Login/SignIn`, JSON.stringify({ username: username, password: password }),
    return this.http.post<any>(`https://localhost:44355/Login/SignIn`, { username: username, password: password },
      {
        headers: new HttpHeaders({
          'Content-Type': 'application/json'
        })
      }
    );
  }
  
}






