import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../User';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  uu!: string;
  private baseUrl = 'http://localhost:5095/api/User';

  loginByNameAndPassword(u: User) {
    return this.http.post<User>(this.baseUrl + "login" + "?name=" + u.Name + "&password=" + u.Password, u);
  }
  register(u: User) {
    return this.http.post<User>(this.baseUrl + "register" + "?user=" + u, u);
  }
  getLocal(pass:string){
    return this.http.get<User>(this.baseUrl + "getLocal" + "?u=" + pass);
  }
  constructor(public http: HttpClient) { }
}
