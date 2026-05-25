import { Component, Input } from '@angular/core';
import { Tabs } from '../tabs/tabs';
import { Allproducts } from '../allproducts/allproducts';
import { Cart } from '../cart/cart';
import { Product } from '../../types';
import { Card } from '../card/card';

@Component({
  selector: 'app-productlists',
  imports: [Tabs, Allproducts, Cart, Card],
  templateUrl: './productlists.html',
  styles: ``,
})
export class Productlists {
  @Input() prodsData: Product[] = [];

  tabCond: string = 'all';

  // get cartProd() {
  //   return this.prodsData.filter((p) => p.isInCart);
  // }

  getTabCond(tc: string) {
    this.tabCond = tc;
  }
}
