import { FoodModel } from "./food-model";

export class CartModel {
    FoodId: number;
    Name: string;
    price: number;
    qty: number;

    constructor(Food: FoodModel, qty = 1){
        this.FoodId = Food.Id;
        this.Name = Food.Name;
        this.price = Food.Price;
        this.qty = qty;
    }
}
