import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[appCustomdir]',
})
export class Customdir {
  constructor(private ele: ElementRef) {
    ele.nativeElement.style.background = 'red';
  }
  @HostListener('mouseover') mouseOverEle() {
    this.ele.nativeElement.style.background = this.hamada;
  }
  @HostListener('mouseout') mouseOutEle() {
    this.ele.nativeElement.style.background = 'white';
  }

  @Input() hamada = '';
}
