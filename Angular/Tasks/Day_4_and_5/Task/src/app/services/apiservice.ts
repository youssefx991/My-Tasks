import { inject, Injectable } from '@angular/core';
import { baseUrl, User, Task } from '../../types';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class APIService {
  http : HttpClient = inject(HttpClient);
  baseUrl : string = baseUrl;
  tasksUrl : string = this.baseUrl + 'tasks/';
  usersUrl : string = this.baseUrl + 'users/';

  getTasks() {
    return this.http.get<Task[]>(this.tasksUrl);
  }

  getUsers() {
    return this.http.get<User[]>(this.usersUrl);
  }

  addUser(user: User) {
    return this.http.post<User>(this.usersUrl, user);
  }

}
