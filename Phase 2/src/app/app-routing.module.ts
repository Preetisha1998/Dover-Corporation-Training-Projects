import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './component/admin/admin/admin.component';
import { CheckoutComponent } from './component/food-cart/checkout/checkout.component';
import { FoodCartComponent } from './component/food-cart/food-cart.component';
import { AdminFoodListComponent } from './component/admin/admin-food-list/admin-food-list.component';
import { AdminFoodEditComponent } from './component/admin/admin-food-list/admin-food-edit/admin-food-edit.component';

const routes: Routes = [
  { path:'', redirectTo: '/foodcart', pathMatch:'full'},
  { path: 'foodcart', component: FoodCartComponent },
  { path: 'checkout', component: CheckoutComponent },
  { path: 'admin', component: AdminComponent },
  { path: 'adminfoodlist', component: AdminFoodListComponent },
  { path: 'foodadd/:id', component: AdminFoodEditComponent },
  { path: 'foodedit/:id', component: AdminFoodEditComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
