import {
  ChangeDetectionStrategy,
  Component,
  ContentChild,
  ElementRef,
  ViewChild,
} from '@angular/core';
import { Comp3 } from '../comp3/comp3';
import { Customdir } from '../directives/customdir';

@Component({
  selector: 'app-comp1',
  imports: [Comp3, Customdir],
  templateUrl: './comp1.html',
  styles: `
    :host {
      display: block;
      background-color: green;
      padding: 10px;
    }
  `,

  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class Comp1 {
  get dis() {
    console.log('%capp Comp1', 'color : blue');
    return;
  }

  ngOnInit() {
    console.log('ngOnInit');
  }

  @ContentChild('h1InApp') h1inapp!: ElementRef;
  @ViewChild('h1incomp1') h1incomp1!: ElementRef;
  ngAfterContentInit() {
    console.log('ngAfterContentInit');
    // initial CD
    // console.log(this.h1inapp.nativeElement);
    // this.h1inapp.nativeElement.style.color = 'red';
  }
  ngAfterContentChecked() {
    console.log('ngAfterContentChecked');

    // console.log('checked', this.h1inapp.nativeElement);
  }
  ngAfterViewInit() {
    console.log('ngAfterViewInit');
    console.log(this.h1incomp1.nativeElement);
    // this.h1incomp1.nativeElement.style.color = 'gray';
  }
  ngAfterViewChecked() {
    console.log('ngAfterViewChecked');

    console.log('checked', this.h1incomp1.nativeElement);
  }
}
