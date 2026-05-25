import { ChangeDetectorRef, Component } from '@angular/core';

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
})
// class Counter {
//   count = 0;

//   inc() {
//     this.count++;
//   }
// }
export class Comp4 {
  // Dependancy Injection => Singlton
  // hamda => name = "ahmed"
  // CounterService!: Counter;
  // constructor(counter: Counter) {
  //   // this.CounterService = new Counter();
  //   this.CounterService = counter;
  // }

  // inject ChangeDetectorRef
  // c!: ChangeDetectorRef;
  constructor(private cd: ChangeDetectorRef) {
    // this.c = cd;
  }

  count = 0;
  get dis() {
    console.log('%capp Comp4', 'color : gray');
    return;
  }

  fun() {
    console.log('Comp4 fun');
    setInterval(() => {
      this.count++;
      console.log(this.count);
      // this.cd.detectChanges();
      // this.cd.markForCheck();
    }, 1000);
    // this.count++;
  }
}
