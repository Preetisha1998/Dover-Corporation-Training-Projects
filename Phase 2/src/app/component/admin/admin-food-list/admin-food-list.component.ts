import { Component, OnInit } from '@angular/core';
import { FoodModel } from 'src/app/models/food-model';
import { FoodService } from 'src/app/services/food.service';

@Component({
  selector: 'app-admin-food-list',
  templateUrl: './admin-food-list.component.html',
  styleUrls: ['./admin-food-list.component.css']
})
export class AdminFoodListComponent implements OnInit {

  foodList: FoodModel[] = [];
  constructor(private foodservice:FoodService) { }

  ngOnInit(): void {
    this.foodList = this.foodservice.getFoodItems();
  }

  onDelete(id:number){
    if(confirm('Are you Sure?')){
    this.foodservice.onDelete(id);
    }
  }
  
}
