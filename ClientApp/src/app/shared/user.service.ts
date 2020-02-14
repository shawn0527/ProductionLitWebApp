import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from './user.model';
import { Url } from './url';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) {
  }

  registerUser(user: User) {
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
        "Content-Type": "application/json"
      }
    };

    return this.http.post(Url.serverSideBaseUrl + '/api/Users', body, options)
      .subscribe(
        result => {
          console.log(result)
        },

        error => {
          console.log("error posting to api: " + error);
        }
      )
  }

  afterRegistration() {

  }

}
