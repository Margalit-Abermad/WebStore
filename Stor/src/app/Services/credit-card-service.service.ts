import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
// import { Observable } from 'rxjs-compat';
import { Observable } from 'rxjs/internal/Observable';


@Injectable({
  providedIn: 'root'
})



export class CreditCardServiceService {
  constructor(private http:HttpClient) { }

  private baseUrl = 'http://localhost:5095/api/CreCard';
  formData: PaymentDetail = new PaymentDetail();
  list!: PaymentDetail[];
  
  postPaymentDetail(obj:any) {
    return this.http.post(this.baseUrl, this.formData);
  }

  addCard(Card: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<any>(this.baseUrl, Card, httpOptions);
  }

  getAllCards():Observable<Card[]>{
    return this.http.get<Card[]>(this.baseUrl);
  }

  getCardById(number: string):Observable<Card[]>{
    return this.http.get<Card[]>(`${this.baseUrl}/${number}`);
  }
  
  deleteCard(id: string): Observable<any> {
    return this.http.delete(`${this.baseUrl}/${id}`, { responseType: 'text' });
  }
}
export interface Card{
  UserId :number
  Number :string
  Cvv :string
  Validity :string
}

export class PaymentDetail {
  UserId :number=0
  Number :string=''
  Cvv :string=''
  Validity :string=''
}