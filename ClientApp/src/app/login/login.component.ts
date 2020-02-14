import { Component, OnInit } from '@angular/core';
import { CompanyService } from '../shared/company.service';
import { Company } from '../shared/company.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public companies = [];

  constructor(private companyService: CompanyService) { }

  ngOnInit() {
    this.companyService.getCompanies()
      .subscribe(
        result => {
          this.companies = result;
         //// debugger
         // for (var i = 0; i < result.length; i++) {
         //   console.log(result[i].companyName)
         //   this.companies.push(result[i].companyName)
         // }
          //this.companies = [{ "id": 1, "companyName": "CompanyA", "userList": null, "subscriptionLevel": "Alpha", "createdTime": "2020-02-04T16:06:51.4569145" }, { "id": 3, "companyName": "Company B", "userList": null, "subscriptionLevel": null, "createdTime": "2020-02-12T13:36:24.0130964" }, { "id": 4, "companyName": "Company C", "userList": null, "subscriptionLevel": null, "createdTime": "2020-02-12T13:37:23.7430479" }, { "id": 5, "companyName": "Company D", "userList": null, "subscriptionLevel": null, "createdTime": "2020-02-12T13:37:28.0070574" }, { "id": 6, "companyName": "Company E", "userList": null, "subscriptionLevel": null, "createdTime": "2020-02-12T13:37:37.5132535" }, { "id": 7, "companyName": "Company F", "userList": null, "subscriptionLevel": null, "createdTime": "2020-02-12T13:37:41.8811521" }, { "id": 8, "companyName": "Company G", "userList": null, "subscriptionLevel": null, "createdTime": "2020-02-12T13:37:46.0024112" }, { "id": 9, "companyName": "Company H", "userList": null, "subscriptionLevel": null, "createdTime": "2020-02-12T13:37:50.0045368" }]
          console.log(this.companies)
        },
        error => {
          console.log(error)
        }
    );
  }

  

}


