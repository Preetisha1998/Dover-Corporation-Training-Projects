import { Component, OnInit } from '@angular/core';
import { CartModel } from 'src/app/models/cart-model';
import { CartService } from 'src/app/services/cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {

  cartModelItems: CartModel[] = [];

  constructor(private cartservice: CartService) { }

  ngOnInit(): void {
    this.cartModelItems = this.cartservice.getCartItems();
    this.cartservice.AddItemsToCart();
    }

  calcTotal(){
    let cartTotal = 0;
    for(let item of this.cartModelItems){
      cartTotal += item.price * item.qty;
    }
    return cartTotal;
  }
  DeleteCartItem(FoodId:number){
    this.cartservice.RemoveFoodfromCart(FoodId);
    }
}