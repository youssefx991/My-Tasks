import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-counter2',
  imports: [],
  templateUrl: './counter2.html',
  styles: `
    :host {
      margin-top: 10px;
      color: white;
      display: block;
      padding: 10px;
      background-color: purple;
      border: 2px solid black;
    }
  `,
})
export class Counter2 {
  countInCounter2: number = 0;

  //  create custom Event -> instance of EventEmitter
  @Output() sendDataFromCounter2ToParent = new EventEmitter(); // is not fired yet
  
  
  inc() {
    this.sendDataFromCounter2ToParent.emit(++this.countInCounter2);
  }
}
