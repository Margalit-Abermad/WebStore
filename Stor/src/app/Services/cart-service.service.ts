import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Product } from '../products/products.component';

@Injectable({
  providedIn: 'root'
})
export class CartServiceService {

  cart=[]
  price!:number;
  
  constructor(private http:HttpClient) { 
    this.price=0;
  }

  private baseUrl = 'http://localhost:5095/api/CreCart';
  // formData: PaymentDetail = new PaymentDetail();
  // list!: PaymentDetail[];
  
  // postPaymentDetail(obj:any) {
  //   return this.http.post(this.baseUrl, this.formData);
  // }

  getAllCart():Observable<Cart[]>{
    return this.http.get<Cart[]>(this.baseUrl);
  }

  getCartById(number: string):Observable<Cart[]>{
    return this.http.get<Cart[]>(`${this.baseUrl}/${number}`);
  }

  addProd(Prod: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<any>(this.baseUrl, Prod, httpOptions);
  }



  CurrentOrder(p:Product){
    this.addProd(p);
    //this.price+=p.Price;
    alert(p.Price);
    // this.inOrders.push(p);
    // this.sum=this.sum+p.price;
  }
}

export interface Cart{
  UserId :number
  Number :string
  Cvv :string
  Validity :string
}

// export class PaymentDetail {
//   UserId :number=0
//   Number :string=''
//   Cvv :string=''
//   Validity :string=''
// }

