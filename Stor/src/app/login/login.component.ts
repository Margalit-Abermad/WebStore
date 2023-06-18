import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserServiceService } from '../Services/user-service.service';
import { User } from '../User';
// import { User } from '../User';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  uLocal: User = new User(0, "", "", "");
  user1: User = new User(0, "", "", "");
  u: string = " ";
  constructor(public myRouter: Router, public userSer: UserServiceService) {
    
   }
    myForm: FormGroup = new FormGroup({
    name: new FormControl(null, Validators.required),
    password: new FormControl(null, Validators.required),
    //agree: new FormControl(false, Validators.requiredTrue),
  });
  inputLogin(value: string) {
    this.u = value;
  }

  // public
  submit() {

    this.userSer.loginByNameAndPassword(this.user1).subscribe(s => {

      this.userSer.getLocal(this.user1.Password).subscribe((ss: any) => {
        console.log("s", ss);
        this.uLocal = ss;
        console.log("s1", this.uLocal);
      }, (err: any) => {
        console.log(err);
      })

        localStorage.setItem("userName", this.uLocal.Name.toString()),
        localStorage.setItem("password", this.uLocal.Password),
        // localStorage.setItem("kodUser", this.uLocal.KodUser.toString()),
        localStorage.setItem("email", this.uLocal.Email.toString()), alert("welcome"), this.myRouter.navigate(['allRecipe'])

    }, (ss1: { status: number; }) => { if (ss1.status == 409) alert("הסיסמה שגויה"); this.userSer.uu = this.u, this.myRouter.navigate(['register']) })
  }
  ngOnInit(): void {
  }

}
