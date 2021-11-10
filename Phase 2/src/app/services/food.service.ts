import { Injectable } from '@angular/core';
import { FoodModel } from '../models/food-model';
@Injectable({
  providedIn: 'root'
})
export class FoodService {
  foods: FoodModel[] = [
    new FoodModel(1, 'Roti', 'Roti is a round flatbread native to the Indian subcontinent made from stoneground whole wheat flour, traditionally known as gehu ka atta, and water that is combined into a dough.', 30, 'https://www.cookwithmanali.com/wp-content/uploads/2021/07/Tandoori-Roti-500x500.jpg'),
    new FoodModel(2, 'Naan', 'Naan is a leavened, oven-baked or tawa-fried flatbread which is found in the cuisines mainly of Western Asia, Central Asia, Indian subcontinent, Indonesia, Myanmar and the Caribbean.', 40, 'https://www.vegrecipesofindia.com/wp-content/uploads/2013/07/naan-recipe-2.jpg'),
    new FoodModel(3, 'Paneer Butter Masala', 'Paneer butter masala, also known as butter paneer is a rich & creamy curry made with paneer, spices, onions, tomatoes, cashews and butter.', 160, 'https://www.vegrecipesofindia.com/wp-content/uploads/2020/01/paneer-butter-masala-5.jpg'),
    new FoodModel(4, 'Palak Paneer', 'Palak paneer is a classic curry dish from North Indian cuisine made with fresh spinach, onions, spices, paneer and herbs.', 180, 'https://www.vegrecipesofindia.com/wp-content/uploads/2021/06/palak-paneer-3.jpg'),
    new FoodModel(5, 'Veg Kohlapuri', 'Vegetable kolhapuri is a dish from the city of Kolhapur in Maharashtra, India consisting of mixed vegetables in a thick, spiced gravy.', 170, 'https://www.vegrecipesofindia.com/wp-content/uploads/2014/11/veg-kolhapuri-recipe-2-1.jpg'),
    new FoodModel(6, 'Punjabi Chole', 'Chickpeas Indian curry where chickpeas are cooked with lots and lots of spices. Goes well with naan, roti or plain rice.', 200, 'https://profusioncurry.com/wp-content/uploads/2019/04/Chana-Masala-Punjabi-Chole-feature-image-480x480.jpg'),
    new FoodModel(7, 'Gobi Manchuri', 'Gobi Manchurian is a class of Indian Chinese dishes made by roughly chopping and deep-frying a main ingredient cauliflower and then sautéeing it in a sauce flavored with soy sauce.', 130, 'https://ikneadtoeat.com/wp-content/uploads/2018/11/Gobi-Manchurian-1-500x500.jpg'),
    new FoodModel(8, 'Paneer Manchuri', 'Paneer Manchurian is a class of Indian Chinese dishes made by roughly chopping and deep-frying a main ingredient cottage cheese and then sautéeing it in a sauce flavored with soy sauce.', 200, 'https://www.vegrecipesofindia.com/wp-content/uploads/2014/12/paneer-manchurian-recipe-1.jpg'),
    new FoodModel(9, 'Veg Pulao', 'Vegetable Pulao is a spicy rice dish prepared by cooking rice with various vegetables and spices.', 170, 'https://www.spiceupthecurry.com/wp-content/uploads/2019/07/spicy-veg-pulao-14-500x500.jpg'),
    new FoodModel(10, 'Veg Biryani', 'Veg biryani is an aromatic rice dish made with basmati rice, spices & mixed veggies.',200,'https://static.toiimg.com/thumb/53098310.cms?imgsize=579584&width=800&height=800'),
    new FoodModel(11, 'Paneer Biryani', 'Paneer biryani is an aromatic rice dish made with basmati rice, spices & mixed veggies with cottage cheese.',250,'https://thebellyrulesthemind.net/wp-content/uploads/2020/02/instant-pot-paneer-biryani-480x480.png')
  ]
  constructor() { }
  getFoodItems():FoodModel[] {
    return this.foods;
  }

  onAdd(food:FoodModel){
    this.foods.push(food);
  }
  onDelete(id:number){
    let food = this.foods.find(x=>x.Id == id) as FoodModel;
    let index = this.foods.indexOf(food,0);
    this.foods.splice(index,1);
  }
  onGetFood(id:number){
    return this.foods.find(x=>x.Id === id);
  }
  onUpdate(food:FoodModel){
    let oldFood = this.foods.find(x=>x.Id == food.Id) as FoodModel;
    oldFood.Name = food.Name;
    oldFood.Description = food.Description;
    oldFood.Price = food.Price;
    oldFood.ImageUrl = food.ImageUrl;
  }
}
