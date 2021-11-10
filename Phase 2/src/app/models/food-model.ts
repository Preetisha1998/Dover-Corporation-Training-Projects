export class FoodModel {
    Id: number;
    Name: string;
    Description: string;
    Price: number;
    ImageUrl: string;

    constructor(Id = 0, Name = '', Description = '', Price = 0, ImageUrl = ''){
        this.Id = Id
        this.Name = Name
        this.Description = Description
        this.Price = Price
        this.ImageUrl = ImageUrl
    }
}
