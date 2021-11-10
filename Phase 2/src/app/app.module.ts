import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HeaderComponent } from './component/shared/header/header.component';
import { FooterComponent } from './component/shared/footer/footer.component';
import { NavComponent } from './component/shared/nav/nav.component';
import { FoodCartComponent } from './component/food-cart/food-cart.component';
import { SearchComponent } from './component/food-cart/search/search.component';
import { FoodListComponent } from './component/food-cart/food-list/food-list.component';
import { CartComponent } from './component/food-cart/cart/cart.component';
import { FoodItemComponent } from './component/food-cart/food-list/food-item/food-item.component';
import { CheckoutComponent } from './component/food-cart/checkout/checkout.component';
import { AppRoutingModule } from './app-routing.module';
import { CheckoutItemComponent } from './component/food-cart/checkout/checkout-item/checkout-item.component';
import { AdminComponent } from './component/admin/admin/admin.component';
import { FormsModule } from '@angular/forms';
import { AdminFoodListComponent } from './component/admin/admin-food-list/admin-food-list.component';
import { AdminFoodEditComponent } from './component/admin/admin-food-list/admin-food-edit/admin-food-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NavComponent,
    FoodCartComponent,
    SearchComponent,
    FoodListComponent,
    CartComponent,
    FoodItemComponent,
    CheckoutComponent,
    CheckoutItemComponent,
    AdminComponent,
    AdminFoodListComponent,
    AdminFoodEditComponent,
    ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
