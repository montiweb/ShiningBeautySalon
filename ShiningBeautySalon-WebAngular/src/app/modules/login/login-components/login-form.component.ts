import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { AuthenticationService } from '../../../core/api-service/authentication.service';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {

  username: string;
  password: string;
  errorMessage = '';

  constructor(
    private authenticationService: AuthenticationService,
    private router: Router) { }

  ngOnInit() { }

  login(loginForm: any): void {

    this.username = loginForm.value.username;
    this.password = loginForm.value.password;

    this.authenticationService.login(this.username, this.password)
      .subscribe(
        (data: any) => {
          if (data) {
            this.router.navigate(['/panel/1']);
          }
        });
  }
}
