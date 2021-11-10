import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { FoodModel } from 'src/app/models/food-model';
import { FoodService } from 'src/app/services/food.service';

@Component({
  selector: 'app-admin-food-edit',
  templateUrl: './admin-food-edit.component.html',
  styleUrls: ['./admin-food-edit.component.css']
})
export class AdminFoodEditComponent implements OnInit {

  id:any;
  header:any;
  food?: FoodModel={ Id:0, Name:'', Description:'',Price:0, ImageUrl:'' };

  constructor(private route: ActivatedRoute, private foodservice: FoodService, private router: Router) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id');
    console.log(this.id);
    if(this.id==0){
      this.header = "Add Food Item";
    } else{
      this.header = "Edit Food Item";
      this.food = this.foodservice.onGetFood(this.id);
    }
  }

  onSubmit(form: NgForm){
    let food: FoodModel = {
      Id: form.value.id,
      Name: form.value.name,
      Description: form.value.description,
      Price: form.value.price,
      ImageUrl: form.value.imageurl
    }
    if(this.id==0){
      this.foodservice.onAdd(food);
    }
    else{
      this.foodservice.onUpdate(food);
    }
    this.router.navigateByUrl('/adminfoodlist');
  }

}
