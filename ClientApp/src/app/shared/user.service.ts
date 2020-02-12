import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpHeaderResponse, HttpRequest } from '@angular/common/http';
import { HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
//import 'rxjs/add/operator/map';
import { User } from './user.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  readonly rootUrl = 'http://localhost:8888';
  constructor(private http: HttpClient, @Inject('BASE_URL') private originUrl) { }
  private myHeader = new HttpHeaders();
  

  getHeaders() {  
    this.myHeader = new HttpHeaders();
    this.myHeader.set("Access-Control-Allow-Origin", "*");
    this.myHeader.set("Content-Type", "application/json");
    return this.myHeader
  }

  registerUser(user: User) {
    this.myHeader = this.getHeaders()
    const body: User = {
      "FirstName": user.FirstName,
      "LastName": user.LastName,
      "EmailAddress": user.EmailAddress,
      "Password": user.Password,
      "CompanyId": 1,
      "Admin": false
    }
    
    const options = {
      headers: {
        "Access-Control-Allow-Origin": "*",
        "Access-Control-Allow-Methods": "DELETE, POST, GET, OPTIONS",
        "Content-Type": "application/json"
      }
    }

    return this.http.post(this.rootUrl + '/api/Users', body, options)
      .subscribe(result => {
    return result; 
    },
      error => {
        console.log("error posting to api: ");
        console.log(error);
      })
  }

}
