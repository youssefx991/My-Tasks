import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-tabs',
  imports: [],
  templateUrl: './tabs.html',
  styles: ``,
})
export class Tabs {
  @Output() tabCondEvent = new EventEmitter();
  all() {
    this.tabCondEvent.emit('all');
  }
  cart() {
    this.tabCondEvent.emit('cart');
  }
}
