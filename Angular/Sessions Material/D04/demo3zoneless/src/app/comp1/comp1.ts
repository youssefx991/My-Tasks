import { Component } from '@angular/core';
import { Comp3 } from '../comp3/comp3';

@Component({
  selector: 'app-comp1',
  imports: [Comp3],
  templateUrl: './comp1.html',
  styles: `
    :host {
      display: block;
      background-color: green;
      padding: 10px;
    }
  `,
})
export class Comp1 {
  get dis() {
    console.log('%capp Comp1', 'color : blue');
    return;
  }
}
