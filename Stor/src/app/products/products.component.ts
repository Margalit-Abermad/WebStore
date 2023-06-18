import { Component, Input, OnInit } from '@angular/core';
import { CartServiceService } from '../Services/cart-service.service';
import { ProductsServiceService } from '../Services/products-service.service';



@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})

// interface a {
//   Image: string ;
//   Name: string;
//   Price: number;
// }

export class ProductsComponent implements OnInit {
  @Input() prod!:Product;
  Products:any;
  Products2:Product[]=[];
  model: Product=new Product()


   Image!: string ;
   Name!: string;
   Price!: number;
   Department!: string; 
   Add!:string;
  constructor(private serve:ProductsServiceService, private CartService:CartServiceService) { 
     this.Products=serve.GetProducts();
     //this.Products=serve.getAllProducts().subscribe();
     //console.log(this.Products);
  }


  ngOnInit(): void {
    //from C#, images not work
    //this.getAllProducts();


    // this.serve.getProductsList().;
    // this.serve.fetch().subscribe(
    //   (data)=>
    //   {
    //     // console.log(res)
    //     // this.Name=data.Name;
    //   });
  }
  getAllProducts(){
    this.serve.getAllProducts().subscribe(
      res=>{
        (this.Products2=res);
        console.log(res);
      }
    );
  }

  AddCart(Product:Product){
    this.CartService.CurrentOrder(this.model);
    //this.Add="Added!";
    // Product
    // setTimeout(() => {
    //   this.Add="Add cart";
    // }, 500); 
    alert(`${Product.Name} Added cart`)
   }
   
  // getProductsList(){
  //    this.Products=this.serve.getProductsList();
  //    return this.Products;
  // }

  // getProductById(){
     
  // }

  // Hello(){
  //   console.log('Hello');
  // }
}

export class Product {
  Image!: string ;
  Name!: string;
  Price!: number;
}
