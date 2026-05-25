import { Component } from '@angular/core';

@Component({
  selector: 'app-comp3',
  imports: [],
  templateUrl: './comp3.html',
  styles: `
    :host {
      display: block;
      background-color: yellow;
      padding: 10px;
    }
  `,
})
export class Comp3 {
  get dis() {
    console.log('%capp Comp3', 'color : green');
    return;
  }
}
