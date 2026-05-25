import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { First } from './components/first/first';
import { Second } from './components/second/second';
@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  imports: [FormsModule],
  // imports: [First, Second],
  styles: `
    :host {
      display: block;
      background-color: chocolate;
      border: 2px black solid;
      padding: 15px;
    }

    // h1 {
    //   background-color: green;
    // }

    .bg {
      background-color: yellow;
    }
    .c {
      color: green;
    }
    .b {
      border: 2px solid;
    }

    .a {
      background-color: green;
    }
    .e {
      background-color: red;
    }

    .formCon {
      padding: 20px;
      background-color: gray;
      width: 50%;
      display: flex;
      flex-direction: column;
      justify-content: center;
      align-items: center;
    }

    input {
      width: 30%;
    }
  `,
})
export class App {
  name: string = 'ali';
  imageURL: string = 'images/1-4.PNG';
  colNum = 2;
  active = true;

  btn = {
    'background-color': 'red',
  };

  dis() {
    return 'hamda';
  }

  // nameStd = 'dgadsg';
  // age = '45';

  // arr = [5, 5, 6, 54];

  std: {
    name: string;
    age: string;
  } = {
    name: '',
    age: '',
  };

  stdArr: {
    name: string;
    age: string;
  }[] = [];

  getName(e: Event) {
    // this.std.name = n;
    // console.log(n.target.value);
    let i = e.target as HTMLInputElement;
    this.std.name = i.value;
  }
  getAge(a: string) {
    this.std.age = a;
  }

  addStd() {
    this.stdArr.push(this.std);
    console.log(this.stdArr);
  }
  // template : ()=>{
  //   this
  // }
}

// const
// document.getElementById("h")?.innerHTML= object.nam

// binding -> data transfer
// form ts -> html
// or html -> ts
// one way binding ts -> html
//    (1) interpolation -> {{}}
//    (2) property binding
//    (3) attribute binding
//    (4) class , style

// event binding html -> ts

// two way binding ts <-> html
// -> with anything got (value -> property)
// ngModel -> banana in box   [(ngModel)]='std.name'
// should import FormsModule

// first[ng-1]
// host -> app-root
// :host {
//   display: block;
//   background-color: chocolate;
//   border: 2px black solid;
// }

// first {
//   display: block;
//   background-color: cadetblue;
//   border: 2px black solid;
// }
