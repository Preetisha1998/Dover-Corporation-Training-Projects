import { Component, OnInit, Input } from '@angular/core';
import { FoodModel } from 'src/app/models/food-model';
import { MessengerService } from 'src/app/services/messenger.service';

@Component({
  selector: 'app-food-item',
  templateUrl: './food-item.component.html',
  styleUrls: ['./food-item.component.css']
})
export class FoodItemComponent implements OnInit {
  @Input() foodItem?: FoodModel 
  constructor(private msg: MessengerService) { }

  ngOnInit(): void {
  }

  handleAddtoCart(){
    this.msg.sendMsg(this.foodItem);
  }

}
