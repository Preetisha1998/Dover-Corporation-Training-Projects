import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-checkout-item',
  templateUrl: './checkout-item.component.html',
  styleUrls: ['./checkout-item.component.css']
})
export class CheckoutItemComponent implements OnInit {
  @Input() checkoutItem: any;
  constructor() { }

  ngOnInit(): void {
    console.log(this.checkoutItem);
  }

}
