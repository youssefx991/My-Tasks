// (function () {
//   require("./scriot2.js");

//   var x = 5; // window.x

//   function add(n1, n2) {
//     return n1 + n2;
//   }

//   // add(5, 5);

//   // console.log(window);

//   console.log(x);
// })(); //IIFE

// (function () {
//   require("./scriot2.js");

//   var x = 5; // window.x

//   function add(n1, n2) {
//     return n1 + n2;
//   }

//   // add(5, 5);

//   // console.log(window);

//   console.log(x);
// })(); //IIFE

// require("./scriot2.mjs"); // run file only once  return obj cache
// require("./scriot2.mjs");
// const obj = require("moment"); // type commonjs
import moment from "moment"; // type module => esmodule
import kamal, { name, name2, name3 } from "./scriot2.js";

console.log(moment);

kamal();

console.log(name);
var x = 5; // window.x

function add(n1, n2) {
  return n1 + n2;
}

// obj.

add(5, 5);

// console.log(window);

console.log(x);
