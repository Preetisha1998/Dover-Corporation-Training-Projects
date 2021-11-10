import { Component, OnInit } from '@angular/core';
import { FoodModel } from 'src/app/models/food-model';
import { FoodService } from 'src/app/services/food.service';

@Component({
  selector: 'app-food-list',
  templateUrl: './food-list.component.html',
  styleUrls: ['./food-list.component.css']
})
export class FoodListComponent implements OnInit {
  foodList: FoodModel[] = []
  constructor(private foodService: FoodService) { }

  ngOnInit(): void {
    this.foodList = this.foodService.getFoodItems(); 
  }

}
