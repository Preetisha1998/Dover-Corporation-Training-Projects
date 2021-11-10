import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AdminModel } from 'src/app/models/admin-model';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {
  email:any;
  password:any;
  AuthenticateLogin = true;
  constructor(private adminservice: AdminService, private router: Router) { }

  ngOnInit(): void {
    
  }
  AdminLogin(){
    this.AuthenticateLogin = this.adminservice.Login(this.email, this.password);
    console.log(this.AuthenticateLogin);
    if(this.AuthenticateLogin == true){
      this.router.navigate(['/adminfoodlist']);
    }else{
      console.log("Login Failed")
    }
  }
}
