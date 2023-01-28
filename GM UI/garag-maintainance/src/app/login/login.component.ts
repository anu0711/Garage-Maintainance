import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { timer } from 'rxjs';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  loginForm: FormGroup;
  loginCount: number = 0;

  constructor(private formBuilder: FormBuilder, private router: Router) {
    this.loginForm = this.formBuilder.group({
      email: ['', [Validators.required, Validators.pattern(/^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$/)]],
      password: ['', Validators.required]
    });
  }

  onSubmit() {
    console.log(this.loginForm.value);
    if (localStorage) {
      const loginInfo = [this.loginForm.value.email, this.loginForm.value.password];
      localStorage.setItem(`loginInfo${this.loginCount}`, JSON.stringify(loginInfo));
      this.loginCount++;
      console.log('Successful login');
      timer(1000).subscribe(() => this.router.navigate(['/dashboard']));
    } else {
      console.log('localStorage is not available');
    }
  }
}