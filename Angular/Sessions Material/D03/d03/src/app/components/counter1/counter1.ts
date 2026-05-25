import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-counter1',
  imports: [],
  templateUrl: './counter1.html',
  styles: `
    :host {
      display: block;
      padding: 10px;
      background-color: yellowgreen;
      border: 2px solid black;
    }
  `,
})
export class Counter1 {
  // define property in input
  @Input() countFromParent: number = 0; // input coming from parent Comp
  // @Input() countFromCounter2: number = 0; // input coming from parent Comp
}
