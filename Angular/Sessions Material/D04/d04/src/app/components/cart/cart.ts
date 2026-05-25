import { Component, Input } from '@angular/core';
import { Card } from '../card/card';
import { Product } from '../../types';

@Component({
  selector: 'app-cart',
  imports: [Card],
  templateUrl: './cart.html',
  styles: ``,
})
export class Cart {
  @Input({
    // alias : ""
    // required : true
    // transform: (prodArr: Product[]) => {
    //   console.log('object');
    //   let cartArr = prodArr.filter((p) => p.isInCart);
    //   return cartArr;
    // },
  })
  cartProsucts: Product[] = []; // if value non-primitve -> change ref

  // get values() {
  //   for (let i = 0; i < 100; i++) {}

  //   return;
  // }
}
