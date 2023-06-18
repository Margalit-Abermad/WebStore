import { Injectable } from '@angular/core';
// import {Http} from '@angular/http';
import {HttpClientModule} from '@angular/common/http';
import { Observable, Subscribable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
// import 'rxjs/add/operator/map';
//  import { map } from 'rxjs';
// import 'rxjs/add/operator/map';
//  import { map } from 'rxjs/operators';
// import { map, catchError } from "rxjs/operators";
// import 'rxjs/add/operator/switchMap';
import 'rxjs-compat/add/operator/map';



@Injectable({
  providedIn: 'root'
})
export class ProductsServiceService {

  Products=[
    {Image:"assets/c1.jpg",Name:"מחשב נייד Asus ROG Zephyrus M16 (2023) GU604VY-NM014X - צבע Off Black AniMe Matrix", Price:7100, Department:"Wommens Shoose"},
    {Image:"assets/c2.jpg",Name:"מחשב נייד Asus TUF Gaming F15 (2023) FX507VV4-LP061 - צבע Mecha Gray", Price:6000, Department:"Wommens Shoese"},
    {Image:"assets/c3.jpg",Name:"מחשב נייד Asus TUF Gaming F17 (2023) FX707VU4-HX048W - צבע Mecha Gray", Price:5486, Department:"Wommens Shoose"},
    {Image:"assets/c4.jpg",Name:"מחשב נייד Asus TUF Gaming F17 FX707ZM-KH088 אסוס‏", Price:1948, Department:"Wommens Shoese"},
    {Image:"assets/c1.jpg",Name:"מחשב נייד Asus ROG Zephyrus M16 (2023) GU604VY-NM014X - צבע Off Black AniMe Matrix", Price:3000, Department:"Wommens Shoose"},
    {Image:"assets/c2.jpg",Name:"מחשב נייד Asus TUF Gaming F15 (2023) FX507VV4-LP061 - צבע Mecha Gray", Price:7363, Department:"Wommens Shoese"},
    {Image:"assets/c3.jpg",Name:"מחשב נייד Asus TUF Gaming F17 (2023) FX707VU4-HX048W - צבע Mecha Gray", Price:2678, Department:"Wommens Shoose"},
    {Image:"assets/c4.jpg",Name:"מחשב נייד Asus TUF Gaming F17 FX707ZM-KH088 אסוס‏", Price:8363, Department:"Wommens Shoese"},
    {Image:"assets/c1.jpg",Name:"מחשב נייד Asus ROG Zephyrus M16 (2023) GU604VY-NM014X - צבע Off Black AniMe Matrix", Price:2990, Department:"Wommens Shoose"},
    {Image:"assets/c2.jpg",Name:"מחשב נייד Asus TUF Gaming F15 (2023) FX507VV4-LP061 - צבע Mecha Gray", Price:3300, Department:"Wommens Shoese"},
    {Image:"assets/c3.jpg",Name:"מחשב נייד Asus TUF Gaming F17 (2023) FX707VU4-HX048W - צבע Mecha Gray", Price:2000, Department:"Wommens Shoose"},
    {Image:"assets/c4.jpg",Name:"מחשב נייד Asus TUF Gaming F17 FX707ZM-KH088 אסוס‏", Price:4980, Department:"Wommens Shoese"}
    ]

  // Products=[];
  
   GetProducts() {
    return this.Products;
  }
  private baseUrl = 'http://localhost:5095/api/Products';

  constructor(private http : HttpClient) {}

  getAllProducts():Observable<Product[]>{
    return this.http.get<Product[]>(this.baseUrl);
  }

  getProductById(id: number): Observable<any> {
    return this.http.get(`${this.baseUrl}/${id}`);
  }

  createProduct(Product: Object): Observable<Object> {
    return this.http.post(`${this.baseUrl}`, Product);
  }

  // updateProduct(id: string, value: any): Observable<Object> {
  //   return this.http.put(`${this.baseUrl}/${id}`, value);
  // }

  updateProduct(Product:object): Observable<Object> {
    return this.http.put(`${this.baseUrl}`, Object);
  }

  deleteProduct(id: number): Observable<any> {
    return this.http.delete(`${this.baseUrl}/${id}`, { responseType: 'text' });
  }

  // getProductsList(): Subscribable<any> {
  //   return this.http.get(`${this.baseUrl}/Products`);//.map(response => response.toString());
  // }
}

interface Product {
  Image: string ;
  Name: string;
  Price: number;
}

  // getProductsList(){
  //   return this.http.get(`${this.baseUrl}/Products`)
  //   .subscribe((res)=>console.log(res));
  // }

  // getProductsList(){
  //   return this.http.get(`${this.baseUrl}/Products`);//.subscribe((res)=>console.log(res));
  // }

  // fetch(){
  //   var root='http://localhost:5095/api';
  //   var url=root+'/Products';
  //   return this.http.get(url)
  //   //   .subscribe(
  //   //    (res)=>console.log(res)
  //   // );
  // }




  // fetch1(){
  //   var root='http://localhost:5095/api';
  //   var url=root+'/Products';
  //   this.http.get(url)
  //   // map((response: any) => response.json())

  //   // .map(
  //   //   (res)=>res.json())
  //     .subscribe(
  //      (res)=>console.log(res)
  //   );

  //   // .map(res => res.json())
  //   // .map(res=>res.toString)
  // }






















  //baseUrl=http://localhost:5095/;
  // getAll():Observable<Products[]>{
  //   return this.http.get(`${this.baseUrl}/list`)
    
  // }

  // fetch(){
  //   var root='http://localhost:5095/';
  //   var url=root+'Products';
  //   this.http.get(url).subscribe(
  //     (res)=>console.log(res));
  // }

