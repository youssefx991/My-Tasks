import { Component, inject, Inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-my-sign-up',
  imports: [FormsModule],
  templateUrl: './my-sign-up.html',
  styleUrl: './my-sign-up.css',
})
export class MySignUp {
  username: string = '';
  email: string = '';
  password: string = '';

  router = inject(Router);
  onSignUp() {
    if (localStorage.getItem('username') === this.username){
      alert('Username already exists. Please choose a different username.');
      return;
    }
    if (localStorage.getItem('email') === this.email){
      alert('Email already exists. Please choose a different email.');
      return;
    }

    if (this.username === '' || this.email === '' || this.password === '') {
      alert('Please fill in all fields.');
      return;
    }
    localStorage.setItem('username', this.username);
    localStorage.setItem('email', this.email);
    localStorage.setItem('password', this.password);
    alert('Sign up successful! You can now log in with your credentials.');
    this.router.navigate(['/login']);
  }
}
