import { ChangeDetectionStrategy, Component, NgZone } from '@angular/core';

@Component({
  selector: 'app-comp4',
  imports: [],
  templateUrl: './comp4.html',
  styles: `
    :host {
      display: block;
      background-color: gray;
      padding: 10px;
    }
  `,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class Comp4 {
  constructor(private zone: NgZone) {}

  count = 0;

  get dis() {
    console.log('%capp Comp4', 'color : gray');
    return;
  }

  fun() {
    console.log('Comp4 fun');

    // this.zone.runOutsideAngular(() => {
    //   setInterval(() => {
    //     // this.count++;
    //     // console.log(this.count);
    //     console.log('object');
    //   }, 1000);
    // });

    // this.count++;
  }
}
