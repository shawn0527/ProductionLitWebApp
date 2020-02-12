import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { User } from '../shared/user.model';
import { UserService } from '../shared/user.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  user = new User();

  constructor(private userService: UserService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null) {
      form.reset()
      this.user = {
        "FirstName": "",
        "LastName": "",
        "EmailAddress": "",
        "Password": "",
        "CompanyId": 1,
        "Admin": false
      }
    }
  }

  onSubmit(form?: NgForm) {
    console.log(form.value)
    this.userService.registerUser(form.value);
  }
}
