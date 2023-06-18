import { Component, Input, OnInit, Output } from '@angular/core';
import {NgForm} from '@angular/forms';
import { SignUpService } from '../Services/sign-up.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {
  @Input() ParentInput: any
  model: User = new User();
  UserF!:User;
  // ar:any[]=[];
  an:any;

  // Products:any;
  // Users:any=[];

  //  Image!: string ;
  //  Name!: string;
  //  Price!: number;
  //  Department!: string; 

  constructor(private service:SignUpService) { }

  ngOnInit(): void {
    //this.service.getUserList();
    //this.service.createUser()
      this.an=this.service.getUserList();
      console.log(this.an)
  }

 
  // getAllUsers(){
  //   this.service.getUserList().subscribe(
  //     res=>{
  //       this.Users=res;
  //       console.log(res);
  //     }
  //   );
  // }

  // onSubmit(loginForm: NgForm){
  //   console.log(this.model);
  //   var ObjToCreate = JSON.stringify(this.model);
  //   console.log("after JSON");
  //   console.log(ObjToCreate);
  //   this.service.createUser(ObjToCreate);
  //   console.log("after");
  // }
  // postPaymentDetail() {
  //   return this.http.post(this.baseURL, this.formData);
  // }
  
  OnSubmit(loginForm:NgForm){
    var ObjToCreate = JSON.stringify(this.model);
    //this.service.createUser(ObjToCreate);
    this.service.addUser(ObjToCreate).subscribe(
      res=>{
        console.log(res)
      }
      , error => {
        alert(`כתובת ${this.model.Email} כבר רשמוה במערכת`)
      }
    );
    // console.log(ObjToCreate);
  }

  OnSubmitB(m:User){
    this.model.FirstName=m.FirstName;
    this.model.LastName=m.LastName;
    this.model.Email=m.Email;
    this.model.Password=m.Password;
    this.UserF=m;
    // this.service.createUser(this.UserF).subscribe(
    //   res=>alert(res.toString())
    // );
    // alert('work')
    // console.log(this.UserF);
    // this.service.createUser(this.UserF);
  }
}

export class User {
  
  constructor() {  }

  public FirstName!: string ;
  // | undefined;
  public LastName!: string ;

  public Email!: string;

  public Password!: string;
  public SavedCreditCard! : string;
  //  | undefined;
  //public email!: string;
}