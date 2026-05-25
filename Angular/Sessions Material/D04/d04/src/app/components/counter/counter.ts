import { Component, EventEmitter, Input, Output, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-counter',
  imports: [],
  templateUrl: './counter.html',
  styleUrl: './counter.css',
})
export class Counter {
  @Input() countFromParent = 0;
  @Input() obj = {};

  // @Output("data")
  // sendCountToParent = new EventEmitter<number>();
  @Output()
  countFromParentChange = new EventEmitter<number>();

  inc() {
    this.countFromParentChange.emit(++this.countFromParent);
  }

  // creation 1️⃣
  constructor() {
    console.log('constructor');

    // self-study
    // afterNextRender() {
    //   console.log('afterNextRender');
    // }

    // afterEveryRender() {
    //   console.log('afterEveryRender');
    // }
  }

  // CD (Change Detection) -> angular hooks -> function -> call at some point of component lifecycle
  ngOnChanges(changes: SimpleChanges) {
    // 2️⃣
    // (1) initial CD
    // (2) update to input property -> @Input changed
    console.log('ngOnChanges');
  }
  ngOnInit() {
    // 3️⃣   intial CD
    // timer
    // call api
    console.log('ngOnInit');
  }
  ngDoCheck() {
    // 4️⃣
    console.log('ngDoCheck');
  }
  // ngAfterContentInit() {
  //   console.log('ngAfterContentInit');
  // }
  // ngAfterContentChecked() {
  //   console.log('ngAfterContentChecked');
  // }
  // ngAfterViewInit() {
  //   console.log('ngAfterViewInit');
  // }
  // ngAfterViewChecked() {
  //   console.log('ngAfterViewChecked');
  // }

  // Destruction
  ngOnDestroy() {
    // compnent died
    // clear memory
    // clear timer
    console.log('ngOnDestroy');
  }
}
