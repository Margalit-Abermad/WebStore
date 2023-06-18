import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { CartComponent } from './cart/cart.component';
import { DepartmentsComponent } from './departments/departments.component';
import { LoginComponent } from './login/login.component';
import { PaymentComponent } from './payment/payment.component';
import { ProductComponent } from './product/product.component';
import { ProductsComponent } from './products/products.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { SignUpComponent } from './sign-up/sign-up.component';

const routes: Routes = [
  {path:'',component:ProductsComponent},
  {path:'Products',component:ProductsComponent},
  {path:'Cart',component:CartComponent},
  {path:'Departments',component:DepartmentsComponent},
  {path:'Cart',component:CartComponent},
  {path:'Sign-Up',component:SignUpComponent},
  {path:'Payment',component:PaymentComponent},
  {path:'Login',component:LoginComponent},
  {path:'Sign-In',component:SignInComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
