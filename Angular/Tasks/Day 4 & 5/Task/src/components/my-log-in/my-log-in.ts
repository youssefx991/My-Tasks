import { Component, inject, Inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
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

  onLogIn() {
    const storedUsername = localStorage.getItem('username');
    const storedPassword = localStorage.getItem('password');

    if (this.username === '' || this.password === '') {
      alert('Please fill in all fields.');
      return;
    }

    if (storedUsername === this.username && storedPassword === this.password) {
      alert('Log in successful!');
      this.router.navigate(['/home']);
      localStorage.setItem('isLoggedIn', 'true');
    } else {
      alert('Invalid username or password. Please try again.');
    }
  }
}
