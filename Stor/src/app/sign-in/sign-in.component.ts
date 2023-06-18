import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { Route, Router } from '@angular/router';
import { SignInServiceService } from '../Services/sign-in-service.service';
import { User } from '../sign-up/sign-up.component';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {

  @Input() ParentInput: any
  model: User = new User();
  UserF!:User;
  // ar:any[]=[];
  an:any;
  user!:User;


  // userForm: FormGroup = new FormGroup({
  //   Email: new FormControl(null, Validators.required),
  //   Password: new FormControl(null, Validators.required),
  //   //agree: new FormControl(false, Validators.requiredTrue),
  // });

  // uLocal: User1 = new User1("","","","");
  // user1: User1 = new User1("","","","");
  u:string="";
  
  constructor(private service:SignInServiceService, private route:Router) { }
  // myForm: FormGroup = new FormGroup({
  //   name: new FormControl(null, Validators.required),
  //   password: new FormControl(null, Validators.required),
  //   //agree: new FormControl(false, Validators.requiredTrue),
  // });
  ngOnInit(): void {
    //this.service.getUserList();
    //this.service.createUser()
      //this.an=this.service.getUserList();
      console.log(this.an)
  }

  inputLogin(value: string) {
    this.u = value;
  }

  OnSubmit(loginForm:NgForm){
    this.model.FirstName="";
    this.model.LastName="";
    this.model.SavedCreditCard="";
    var ObjToCreate = JSON.stringify(this.model);
    //this.service.createUser(ObjToCreate);
    var x=this.service.AuthenticationUser(ObjToCreate).subscribe(
      // res=>console.log(res)
      res =>{
       console.log(res)

       //this.user.Email=this.service.getUserById(this.model.Email);
      //  var obj=
       this.getUserById1();
       //alert(`hello ${this.user.FirstName}`)
      }, error => {
        console.log(error);
        alert("error")
      }
    );
     //console.log(`x= ${x}`);
  }

  getUserById1(){
    this.service.getUserById(this.model.Email).subscribe(
      res=>{
        (this.user=res);
        //console.log(res);
      }
    );
  }

  OnSubmitB(m:User){
    this.model.Email=m.Email;
    this.model.Password=m.Password;
    this.model.FirstName="";
    this.model.LastName="";
    this.model.SavedCreditCard="";
    this.UserF=m;
    // this.service.createUser(this.UserF).subscribe(
    //   res=>alert(res.toString())
    // );
    // alert('work')
    // console.log(this.UserF);
    // this.service.createUser(this.UserF);
  }
  // submit(User1:User) {

  //   this.service.getByIdUser(User1)
  //   // this.service.loginByNameAndPassword(this.user1).subscribe(s => {

  //   //   this.service.getLocal(this.user1.Password).subscribe(ss => {
  //   //     console.log("s", ss);
  //   //     this.uLocal = ss;
  //   //     console.log("s1", this.uLocal);
  //   //   }, err => {
  //   //     console.log(err);
  //   //   })

  //   //     localStorage.setItem("userName", this.uLocal.FirstName.toString()),
  //   //     localStorage.setItem("password", this.uLocal.Password),
  //   //     // localStorage.setItem("kodUser", this.uLocal.KodUser.toString()),
  //   //     localStorage.setItem("email", this.uLocal.Email.toString()), alert("welcome"), this.route.navigate(['/Products'])

  //   // }, ss1 => { if (ss1.status == 409) alert("הסיסמה שגויה"); this.service.uu = this.u, this.route.navigate(['/Sign-Up']) })
  // }


}

// export class User {
  
//   public FirstName!: string ;
//   // | undefined;
//   public LastName!: string ;

//   public Email!: string;

//   public Password!: string;
//   public SavedCreditCard! : string;
//   //  | undefined;
//   //public email!: string;
// }


// export class User1 {
  
//   constructor(public FirstName:string, public LastNam:string, public Email:string, public Password:string) {  }
 
// }