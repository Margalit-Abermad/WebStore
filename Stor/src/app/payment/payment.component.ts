import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { CreditCardServiceService } from '../Services/credit-card-service.service';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.css']
})
export class PaymentComponent implements OnInit {
  contentEditable=false;
  CardD:any
  constructor(private service:CreditCardServiceService) { }
  model: Card = new Card();

  ngOnInit(): void {
    this.getAll();
    // this.OnSubmit();
  }

  getAll(){
    this.service.getAllCards().subscribe(
      res=>{
        console.log(res);
      }
    );
  }

  toggleEditable(event:any) {
    if ( event.target.checked ) {
        this.contentEditable = true;
   }
}

OnSubmit(loginForm:NgForm){
  console.log('entered into OnSubmit  function');
  var ObjToCreate = JSON.stringify(this.model);
  //this.service.createUser(ObjToCreate);
  this.service.addCard(ObjToCreate).subscribe(
    res=>console.log(res)
  );
  // console.log(ObjToCreate);
}

deleteCard(m:Card){
  this.service.deleteCard(m.Number).subscribe(
    res=>{
      console.log(res)
    },
    error=>{
      alert(`אשראי לא שמור במערכת`);
    }
  );
}

OnSubmitB(m:Card){
  this.model.Number=m.Number;
  this.model.CVV=m.CVV;
  this.model.Validity=m.Validity;
  this.CardD=m;
  console.log("entered B");
  console.log(this.CardD);
  // this.service.createUser(this.UserF).subscribe(
  //   res=>alert(res.toString())
  // );
  // alert('work')
  // console.log(this.UserF);
  // this.service.createUser(this.UserF);
}

}



export class Card {
  
  constructor() {  }

  public Number!: string ;

  public CVV!: string;

  public Validity!: string;

}