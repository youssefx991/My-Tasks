import { Component } from '@angular/core';
import { Form } from './components/form/form';
import { Productlists } from './components/productlists/productlists';
import { Product } from './types';
import { Counter } from './components/counter/counter';

@Component({
  selector: 'app-root',
  imports: [Form, Productlists, Counter],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  // productList: Product[] = [];
  product!: Product;
  addToProductList(prod: Product) {
    // this.productList.push(prod);
    this.product = prod;
    // this.product.name = "fgdsf"
  }

  count = 0;

  show = true;

  updateCount(n: number) {
    this.count = n;
  }
}
