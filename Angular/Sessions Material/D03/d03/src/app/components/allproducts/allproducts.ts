import { Component, Input } from '@angular/core';
import { Card } from '../card/card';
import { Product } from '../../types';

@Component({
  selector: 'app-allproducts',
  imports: [Card],
  templateUrl: './allproducts.html',
  styles: ``,
})
export class Allproducts {
  // @Input('hamda') data: Product[] = [];
  @Input({
    alias: 'hamda',
    required: true,
  })
  data: Product[] | null = null;
}
