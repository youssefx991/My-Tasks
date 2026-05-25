import { Component } from '@angular/core';
import { MyHeader } from "../my-header/my-header";
import { RouterOutlet } from "@angular/router";

@Component({
  selector: 'app-my-home',
  imports: [MyHeader, RouterOutlet],
  templateUrl: './my-home.html',
  styleUrl: './my-home.css',
})
export class MyHome {}
