import { Component, inject, Inject } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-my-log-in',
  imports: [FormsModule],
  templateUrl: './my-log-in.html',
  styleUrl: './my-log-in.css',
})
export class MyLogIn {
  username: string = '';
  password: string = '';
  router = inject(Router);

  onLogIn(loginForm : NgForm) {
    if (loginForm.invalid) {
      alert('Please fill in all fields correctly.');
      return;
    }
    const storedUsername = localStorage.getItem('username');
    const storedPassword = localStorage.getItem('password');


    if (storedUsername === this.username && storedPassword === this.password) {
      alert('Log in successful!');
      this.router.navigate(['/home']);
      localStorage.setItem('isLoggedIn', 'true');
    } else {
      alert('Invalid username or password. Please try again.');
    }
  }
}
