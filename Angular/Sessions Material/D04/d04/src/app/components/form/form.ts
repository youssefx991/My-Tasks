import { Component, EventEmitter, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { v4 as uuidv4 } from 'uuid';
import { CommonModule } from '@angular/common';
import { error, Product } from '../../types';

@Component({
  selector: 'app-form',
  templateUrl: './form.html',
  imports: [FormsModule, CommonModule],
})
export class Form {
  @Output() sendProdToParent = new EventEmitter<Product>();

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

  error: error = {
    message: '',
    state: false,
  };
  
  addProduct() {
    this.error.state = false;
    let newProduct = { ...this.product, id: uuidv4().split('-')[1] };
    // this.product.id = uuidv4().split('-')[1];
    for (let key in newProduct) {
      const k = key as keyof Product;
      if (newProduct[k] === '') {
        console.log(k, newProduct[k]);
        this.error.message = 'You Should fill all the values';
        this.error.state = true;
        console.log(this.error);
        return;
      }
    }
    this.sendProdToParent.emit(newProduct);
  }
}
