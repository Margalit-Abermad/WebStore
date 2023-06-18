import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../sign-up/sign-up.component';

@Injectable({
  providedIn: 'root'
})
export class SignInServiceService {
  //http: any;

  constructor(private http:HttpClient) { }
  uu!: string;
  baseUrl = "http://localhost:5095/api/LogIn";
  // loginByNameAndPassword(u: User1) {
  //   return this.http.post<User1>(this.baseUrl + "login" + "?Email=" + u.Email + "&password=" + u.Password, u);
  // }
  // register(u: User1) {
  //   return this.http.post<User1>(this.baseUrl + "register" + "?user=" + u, u);
  // }
  // register(u: User1) {
  //   return this.http.post<User1>(this.baseUrl,u.Email , u.Password);
  // }

  // getLocal(pass:string){
  //   return this.http.get<User>(this.baseUrl + "getLocal" + "?u=" + pass);
  // }

  // AuthenticationUser(User:any) {
  //   return this.http.post(this.baseUrl, User.Name,User.Password)//,User1.Password);
  // }

  AuthenticationUser(User: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<any>(this.baseUrl, User, httpOptions);
  }
  getUserById(id: string): Observable<any> {
    return this.http.get(`${this.baseUrl}/${id}`);
  }
}
