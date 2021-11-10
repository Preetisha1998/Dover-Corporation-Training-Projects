import { Injectable } from '@angular/core';
import { AdminModel } from '../models/admin-model';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
  admins: AdminModel[] = [
    new AdminModel(1, "admin", "admin"),
    new AdminModel(2, "admin1@kitchenstory.com", "admin1")
  ];
  constructor() { }

  getAdminDetails(): AdminModel[]{
    return this.admins;
  }
  Login(email: string, password: string): boolean{
    let AuthenticateLogin = false;
    for(let  i in this.admins ){
      if((email == this.admins[i].AdminId)&&(password == this.admins[i].Password)){
        AuthenticateLogin = true;
        break;
      }
    }
    return AuthenticateLogin;
  }
}
