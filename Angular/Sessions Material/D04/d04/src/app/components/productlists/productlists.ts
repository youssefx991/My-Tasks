import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { Tabs } from '../tabs/tabs';
import { Allproducts } from '../allproducts/allproducts';
import { Cart } from '../cart/cart';
import { Product, tabName } from '../../types';
import { Card } from '../card/card';

@Component({
  selector: 'app-productlists',
  imports: [Tabs, Allproducts, Cart, Card],
  templateUrl: './productlists.html',
  styles: ``,
})
export class Productlists {
  // @Input()
  // productListInChild!: Product[];
  @Input()
  productInChild!: Product; // undefined

  @Input() i1 = 0;

  @Input()
  text!: string;

  list: Product[] = [];
  cartList: Product[] = [];
  tabeName = 'all';

  ngOnChanges(changes: SimpleChanges) {
    console.log('onchanges', changes);

    if (changes['productInChild'].firstChange) return;

    this.list = [...this.list, this.productInChild];

    // this.cartList = this.list.filter((p) => p.isInCart);

    // this.list.push(undefined)

    console.log(this.list);
  }

  // constructor(){
  // } ❌❌❌❌

  // get pushPriduct() {
  //   return this.list.push(this.productInChild);
  // } ⚠⚠

  getId(id: string) {
    // console.log('getid fun');
    // let obj = this.productListInChild.find((p) => p.id === id) as Product;
    // if (obj) {
    //   obj.isInCart = true; // new ref -> product
    // }
    // this.productListInChild = [...this.productListInChild, obj]; // same ref

    // this.productListInChild = this.productListInChild.map((p) => {
    //   if (p.id === id) {
    //     p = { ...p, isInCart: true };
    //   }
    //   return p;
    // });
    this.list = this.list.map((p) => {
      if (p.id === id) {
        p = { ...p, isInCart: true };
      }
      return p;
    });
  }
  getNameTab(name: tabName) {
    this.tabeName = name;
  }
}
