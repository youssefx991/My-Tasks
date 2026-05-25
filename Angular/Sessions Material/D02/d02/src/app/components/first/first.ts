// HTML , CSS , TS

import { Component } from '@angular/core';
import { Third } from '../third/third';

// Component is Class
// define type for the class

// ts decorators => special kind of functions
// => let you add/modify metaData or behavior of class , method , properties
// without changing the actual logic

// functtion   => {} : Component
// (1) selector
// link component with template => (Html)
// (2) link tempplate => template
@Component({
  selector: 'first',
  //   // inline template
  //   template: `<h1>This Is First Component</h1>`,
  templateUrl: './first.html',
  imports: [Third],
  // external tempalte
  // component inline style -> (Not Element Inline Style)
  styles: `
    //   :host {
    //     display: block;
    //     background-color: cadetblue;
    //     border: 2px black solid;
    //     padding: 15px;
    //   }
    //   h1 {
    //     background-color: blue;
    //   }
    //   app-third {
    //     display: block;
    //     background-color: chartreuse;
    //     border: 2px black solid;
    //   }

    // h1 {
    //   background-color: red;
    // }
  `, // higher piority
  // style isolation (Emulation)

  // styleUrl: './first.css',
  styleUrls: ['./first2.css', './first.css'],
})
export class First {}

// // [ng-2]
//     // :host {
//     //   display: block;
//     //   background-color: cadetblue;
//     //   border: 2px black solid;
//     // }
//     h1 {
//       background-color: blue;
//     }
//     app-third {
//       display: block;
//       background-color: chartreuse;
//       border: 2px black solid;
//     }
