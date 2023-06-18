import { Component, OnInit } from '@angular/core';
import { CartServiceService } from '../Services/cart-service.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {
  Products:any;
  inOrder=[];
  allPrice!:number;
  // sum:number;

  constructor(private service:CartServiceService) { 
    // this.inOrder=service.GetinOrders();
    // this.sum=service.GetSum();
    this.allPrice=0;
    this.Products=service.getCartById("1");

  }

  ngOnInit(): void {
  }

}
