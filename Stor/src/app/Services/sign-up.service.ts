import { Injectable } from '@angular/core';
// import {Http} from '@angular/http';
import {HttpClientModule, HttpHeaders} from '@angular/common/http';
import { Observable, Subscribable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

import 'rxjs-compat/add/operator/map';

@Injectable({
  providedIn: 'root'
})
export class SignUpService {

  private baseUrl = 'http://localhost:5095/api/User';

  constructor(private http : HttpClient) { }

  formData:UserDetails = new UserDetails();
  UserDetailsArr=[]


  getUserById(id: string): Observable<any> {
    return this.http.get(`${this.baseUrl}/${id}`);
  }

  //i changed
  // createUser(User: any) {
  //   return this.http.post(this.baseUrl, User);
  // }
  addUser(User: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<any>(this.baseUrl, User, httpOptions);
  }

  postPaymentDetail() {
    return this.http.post(this.baseUrl, this.formData);
  }

  // updateProduct(id: string, value: any): Observable<Object> {
  //   return this.http.put(`${this.baseUrl}/${id}`, value);
  // }

  updateUser(User:object): Observable<Object> {
    return this.http.put(`${this.baseUrl}`, Object);
  }

  deleteUser(id: number): Observable<any> {
    return this.http.delete(`${this.baseUrl}/${id}`, { responseType: 'text' });
  }

  getUserList(): Subscribable<any> {
    return this.http.get(`${this.baseUrl}`);//.map(response => response.toString());
  }

}

export class UserDetails{
  FirstName:string="";
  LastName: string="";
  Email:string="";
  Password:string="";

}

// interface UserDetils{
//   Name:string,
//   LastName:string,
// }
