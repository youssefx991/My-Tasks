import { Component, inject, Inject } from '@angular/core';
import { FormControl, FormGroup, FormsModule, NgForm, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-my-sign-up',
  imports: [ReactiveFormsModule],
  templateUrl: './my-sign-up.html',
  styleUrl: './my-sign-up.css',
})
export class MySignUp {
  signUpForm = new FormGroup({
    username: new FormControl('', [Validators.required, Validators.minLength(3)]),
    email: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [Validators.required, Validators.minLength(6)]),
  })

  router = inject(Router);
  onSignUp() {
    if (this.signUpForm.invalid) {
      alert('Please fill in all fields correctly.');
      return;
    }
    if (localStorage.getItem('username') === this.signUpForm.value.username) {
      alert('Username already exists. Please choose a different username.');
      return;
    }
    if (localStorage.getItem('email') === this.signUpForm.value.email) {
      alert('Email already exists. Please choose a different email.');
      return;
    }

    if (this.signUpForm.value.username === '' || this.signUpForm.value.email === '' || this.signUpForm.value.password === '') {
      alert('Please fill in all fields.');
      return;
    }
    localStorage.setItem('username', this.signUpForm.get('username')?.value || '');
    localStorage.setItem('email', this.signUpForm.get('email')?.value || '');
    localStorage.setItem('password', this.signUpForm.get('password')?.value || '');
    alert('Sign up successful! You can now log in with your credentials.');
    this.router.navigate(['/login']);
  }
}
