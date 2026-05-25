import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Product } from '../../types';

@Component({
  selector: 'app-card',
  imports: [],
  templateUrl: './card.html',
  styles: ``,
})
export class Card {
  @Input() prod!: Product;
  @Output() sendAddToCart = new EventEmitter();

  addToCart(id: string) {
    this.sendAddToCart.emit(id);
  }
}
