import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MessengerService {

  subject = new Subject();

  constructor() { }

  sendMsg(food: any){    
    this.subject.next(food); 
  }

  getMsg(){
    return this.subject.asObservable();
  }
}
