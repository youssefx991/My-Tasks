import { error } from './../../types';
import { Component, EventEmitter, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Product } from '../../types';
import { v4 as uuidv4 } from 'uuid';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-form',
  imports: [FormsModule, CommonModule],
  templateUrl: './form.html',
  styles: `
    .bg {
      background-color: yellow;
    }

    .c {
      color: green;
    }

    .b {
      border: 5px solid black;
    }
  `,
})
export class Form {
  active = true;
  // add(n1: any, n2: any) {
  //   console.log(n1.value);
  //   console.log(n2.value);
  // }
  product: Product = {
    id: '',
    name: '',
    category: '',
    description: '',
    price: '',
    quantity: '',
    imageUrl: '',
    isInCart: false,
    status: 'active',
  };

  err: error = {
    message: '',
    state: false,
  };

  // prodArr: Product[] = [];


  @Output()
  sendProdToApp = new EventEmitter<Product>();

  addProduct() {
    this.err.state = false;
    let newProd: Product = { ...this.product, id: uuidv4().split('-')[0] };
    // this.product.id = uuidv4().split('-')[0];
    for (let p in newProd) {
      let key = p as keyof Product;
      if (newProd[key] === '') {
        console.log('error');
        this.err.message = 'please fill all fields';
        this.err.state = true;
        return;
      }
    }
    // this.prodArr.push(newProd);
    // console.log(this.prodArr);
    this.sendProdToApp.emit(newProd);
    this.err.state = false;

    // this.product = {
    //   id: '',
    //   name: '',
    //   category: '',
    //   description: '',
    //   price: '',
    //   quantity: '',
    //   imageUrl: '',
    //   isInCart: false,
    //   status: 'active',
    // };
  }

  // std = [
  //   {
  //     id: 1546456,
  //     name: 'ali',
  //     age: 25,
  //   },
  //   {
  //     id: 684687,
  //     name: 'ahmed',
  //     age: 45,
  //   },
  //   {
  //     id: 654865,
  //     name: 'kamal',
  //     age: 55,
  //   },
  // ];

  // refresh() {
  //   this.std = [
  //     {
  //       id: 1546456,
  //       name: 'ali',
  //       age: 25,
  //     },
  //     {
  //       id: 684687,
  //       name: 'ahmed',
  //       age: 45,
  //     },
  //     {
  //       id: 654865,
  //       name: 'khaled',
  //       age: 55,
  //     },
  //   ];

  //   // this.std[2].name = 'khaled';
  // }

  // shiftStd() {
  //   this.std.shift();
  // }
  // unshiftStd() {
  //   this.std.unshift({
  //     id: new Date().getSeconds(),
  //     name: 'kamal',
  //     age: 55,
  //   });
  // }

  // trackByFn(index: number, ele: any) {
  //   console.log(ele);
  //   // return index;
  //   return ele.id;
  // }
}

// Directives => class -> decorated @Directive -> class -> selector (attribute -> html element) -> add behavior or modify on Dom Element in tamplate
// built in directives
//           component directive -> Component In Angular is actually directive -> class decorated with @component -> selector , Template , Style
//           attribute directive ->
//                                (1) ngModel
//                                (2) [ngClass]
//                                (3) [ngStyle] [style.fontSize.px]
//                                => CommonModule
//           structure directive => CommonModule
//                                  (1) ngIf
//                                  (2) ngFor
//                                  (3) ngSwitch => selfStudy

// ng-template -> angular custom tag -> as container for html code
// needs instructions (condition) => base on that condition (instruction)= > render content

// custom directives

// control flow => @if(){}
