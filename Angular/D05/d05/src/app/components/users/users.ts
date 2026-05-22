import { Component } from '@angular/core';
import { RouterLink } from "@angular/router";

@Component({
  selector: 'app-users',
  imports: [RouterLink],
  templateUrl: './users.html',
  styles: ``,
})
export class Users {
  get dis() {
    console.log('users');
    return;
  }
}
