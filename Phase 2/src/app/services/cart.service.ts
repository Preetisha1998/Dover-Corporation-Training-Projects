import { Injectable } from '@angular/core';
import { CartModel } from '../models/cart-model';
import { MessengerService } from './messenger.service';
@Injectable({
  providedIn: 'root'
})
export class CartService {
  cartItems: CartModel[] = [];
  constructor(private msg: MessengerService) { }
  getCartItems(){
   return this.cartItems;
  }
  AddItemsToCart(){
      this.msg.getMsg().subscribe((food:any) => {
        this.addFoodtoCart(food);
      })
  }
  addFoodtoCart(food:any){
    let foodExists = false;
    for(let i in this.cartItems){
      if(this.cartItems[i].FoodId === food.Id){
        this.cartItems[i].qty++;
        foodExists = true;
        break;
      }
    }
    if(!foodExists){
      this.cartItems.push(new CartModel(food));
    }

  }
  ReturnTotal(){
    let cartTotal = 0;
    for(let item of this.cartItems){
      cartTotal += item.qty * item.price;
    }
    return cartTotal;
  }
  RemoveFoodfromCart(FoodId : number){
    for(let item of this.cartItems){
      if(item.FoodId == FoodId){
        if(item.qty == 1){
          let index = this.cartItems.indexOf(item, item.FoodId);
          this.cartItems.splice(index,1);
        }else{
          item.qty --;
        }
      }
    }
  }
}