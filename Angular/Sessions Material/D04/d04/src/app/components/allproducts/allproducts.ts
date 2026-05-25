import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Card } from '../card/card';
import { Product } from '../../types';

@Component({
  selector: 'app-allproducts',
  imports: [Card],
  templateUrl: './allproducts.html',
  styles: ``,
})
export class Allproducts {
  @Input({
    // alias: 'allproducts',
    // required : true,
  })
  products: Product[] = [];

  @Output() sendAagain = new EventEmitter();

  getIdAddToCart(id: string) {
    this.sendAagain.emit(id);
  }
}
