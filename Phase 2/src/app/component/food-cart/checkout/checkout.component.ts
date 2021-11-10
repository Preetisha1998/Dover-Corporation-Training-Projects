import { Component, OnInit } from '@angular/core';
import { CartModel } from 'src/app/models/cart-model';
import { CartService } from 'src/app/services/cart.service';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent implements OnInit {

  CartcheckoutItems: CartModel[] = [];
  cartTotal = 0;

  constructor(private cartservice: CartService) { }

  ngOnInit(): void {
    this.CartcheckoutItems = this.cartservice.getCartItems();
    this.cartTotal = this.cartservice.ReturnTotal();
  }
}
