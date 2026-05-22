import { ChangeDetectionStrategy, Component } from '@angular/core';
import { Comp4 } from '../comp4/comp4';

@Component({
  selector: 'app-comp2',
  imports: [Comp4],
  templateUrl: './comp2.html',
  styles: `
    :host {
      display: block;
      background-color: blue;
      padding: 10px;
    }
  `,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class Comp2 {
  get dis() {
    console.log('%capp Comp2', 'color : yellow');
    return;
  }

  d() {
    return;
  }
}
