import { Component, inject, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormsModule, NgForm, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { User } from '../../types';
import { APIService } from '../../app/services/apiservice';
import { v4 as uuidv4 } from 'uuid';

@Component({
  selector: 'app-my-sign-up',
  imports: [ReactiveFormsModule],
  templateUrl: './my-sign-up.html',
  styleUrl: './my-sign-up.css',
})
export class MySignUp implements OnInit {
  signUpForm = new FormGroup({
    username: new FormControl('', [Validators.required, Validators.minLength(3)]),
    email: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [Validators.required, Validators.minLength(6)]),
  })

  router = inject(Router);
  apiService = inject(APIService);
  users: User[] = [];
  ngOnInit() {
      this.apiService.getUsers().subscribe((users: User[]) => {
        this.users = users;
        console.log("Users:", users);
      });
    }
  onSignUp() {
    if (this.signUpForm.invalid) {
      alert('Please fill in all fields correctly.');
      return;
    }
    // check if username or email already exists in the users array
    const emailExists = this.users.some(u => u.email === this.signUpForm.value.email);
     if (emailExists) {
      alert('Email already exists. Please choose a different email.');
      return;
    }
    const usernameExists = this.users.some(u => u.username === this.signUpForm.value.username);
    if (usernameExists) {
      alert('Username already exists. Please choose a different username.');
      return;
    }
    const user = this.users.find(u => u.email === this.signUpForm.value.email);
    if (user) {
      alert('Email already exists. Please choose a different email.');
      return;
    }


    // if (localStorage.getItem('username') === this.signUpForm.value.username) {
    //   alert('Username already exists. Please choose a different username.');
    //   return;
    // }
    // if (localStorage.getItem('email') === this.signUpForm.value.email) {
    //   alert('Email already exists. Please choose a different email.');
    //   return;
    // }

    // if (this.signUpForm.value.username === '' || this.signUpForm.value.email === '' || this.signUpForm.value.password === '') {
    //   alert('Please fill in all fields.');
    //   return;
    // }
    // localStorage.setItem('username', this.signUpForm.get('username')?.value || '');
    // localStorage.setItem('email', this.signUpForm.get('email')?.value || '');
    // localStorage.setItem('password', this.signUpForm.get('password')?.value || '');

    const newUser: User = {
      id: uuidv4().split('-')[0],
      username: this.signUpForm.value.username || '',
      email: this.signUpForm.value.email || '',
      password: this.signUpForm.value.password || ''
    };
    this.apiService.addUser(newUser).subscribe((addedUser: User) => {
      alert('Sign up successful! You can now log in with your credentials.');
    });
    this.router.navigate(['/login']);
  }
}

