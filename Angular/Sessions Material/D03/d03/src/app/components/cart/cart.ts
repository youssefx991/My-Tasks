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
  cart!: Product[];

  @Input({
    alias: 'hamda',
    required: true,
  })
  set data(prods: Product[]) {
    this.cart = prods.filter((p) => p.isInCart);
  }
  // data: Product[] | null = null;

  // set add(fff: string) {
  //   this.data = fff;
  // }
}
