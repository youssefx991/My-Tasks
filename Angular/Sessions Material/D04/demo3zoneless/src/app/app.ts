import { Component } from '@angular/core';
import { Comp1 } from './comp1/comp1';
import { Comp2 } from './comp2/comp2';

@Component({
  selector: 'app-root',
  imports: [Comp1, Comp2],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  get dis() {
    console.log('%capp comp', 'color : red');
    return;
  }
}
