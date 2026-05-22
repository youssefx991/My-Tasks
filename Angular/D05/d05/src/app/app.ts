import { Component, signal } from '@angular/core';
import { Header } from './components/header/header';
import { Home } from './components/home/home';
import { About } from './components/about/about';
import { RouterOutlet } from '@angular/router';
import { Comp1 } from './comp1/comp1';
import { Comp2 } from './comp2/comp2';

@Component({
  selector: 'app-root',
  imports: [Header, RouterOutlet, Comp1, Comp2],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  name = 'hosam';
  get dis() {
    console.log('app');
    return;
  }

  d() {
    // console.log('object');
    return;
  }
}
