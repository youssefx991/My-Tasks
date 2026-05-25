import { Component } from '@angular/core';
import { Form } from './components/form/form';
import { Productlists } from './components/productlists/productlists';
import { Counter1 } from './components/counter1/counter1';
import { Counter2 } from './components/counter2/counter2';
import { Product } from './types';

@Component({
  selector: 'app-root',
  imports: [Form, Productlists, Counter1, Counter2],
  templateUrl: './app.html',
  styles: `
    // :host {
    //   display: block;
    //   padding: 10px;
    //   background-color: chocolate;
    //   border: 2px solid black;
    // }
  `,
})
export class App {
  // count: number = 0;
  // countFromCounter2 = 0;
  // getCounter2(data: any) {
  // console.log(data);
  // this.count = data;
  // this.countFromCounter2 = data;
  // }

  prodArr: Product[] = [
    {
      id: '514351351',
      name: 'dasdasd',
      category: 'asdasd',
      description: 'asdasd',
      price: 'asdasd',
      quantity: '',
      imageUrl: '',
      isInCart: true,
      status: 'active',
    },
    {
      id: '548979',
      name: 'dasdasd',
      category: 'asdasd',
      description: 'asdasd',
      price: 'asdasd',
      quantity: '',
      imageUrl: '',
      isInCart: true,
      status: 'active',
    },
  ];
  getProd(p: Product) {
    this.prodArr.push(p);
    console.log(this.prodArr);
  }
}
