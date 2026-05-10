"use strict";
// class Test{}
//Basic Types
let a1 = 2;
// a1="str"
// a1=true
console.log(a1);
let a2 = "hello";
a2 = "world";
let a3 = true;
// a3=2
function check(arg) {
    if (arg > 2)
        return false;
    return true;
}
let arr = [1, 2, 3];
console.log(arr);
// arr = ["5",2,3,4,5]
function printArray(arr) {
    // console.log(arr)
    arr.forEach(elem => {
        console.log(elem);
    });
}
printArray(arr);
// printArray(27)
let myarr;
myarr = [1, 2, 3];
myarr = 5;
myarr = "str";
//Tuple
let arr1 = [1, 2];
//Object
const user1 = {
    name: "ahmed",
    age: 20,
    address: '123st'
};
console.log(user1.name);
user1.name = "ali";
console.log(user1.name);
// console.log(user1.courses)//error
// user1.salary = 10000
function PrintUser(user) {
    return user.name;
}
console.log(PrintUser(user1));
// PrintUser(1)//error
function add(arg1, arg2) {
    return arg1 + arg2;
}
function concate(arg1, arg2) {
    return arg1 + arg2;
}
function addConcate(arg1, arg2) {
    return arg1 + arg2;
}
console.log(addConcate(1, 1));
console.log(addConcate("str", "str"));
// console.log(addConcate("str",5))//error
let x = 1;
x = true;
x = "xyz";
let y;
y = 5;
y = true;
let u1 = { name: '', address: '', age: 0 };
let u3 = { address: '', age: 0, name: '', permissionLevel: '' };
var PerLeve;
(function (PerLeve) {
    PerLeve[PerLeve["student"] = 0] = "student";
    PerLeve["instructor"] = "instructor";
    PerLeve["admin"] = "admin";
})(PerLeve || (PerLeve = {}));
let p1 = PerLeve.student;
p1 = "admin";
console.log(p1);
// p1=1
// p1=2
// p1=3
// interface IUser{
//     name:string
//     age:number
//     courses:string[]
// }
// interface IUserExtend extends IUser{
//     permissionLevel:string
// }
// let u2:IUserExtend={
//     name:'ali',
//     age:20,
//     courses:[],
//     // address:"xyz"
//     permissionLevel:''
// }
//tsc --watch file.ts
function firstElement(arr) {
    return arr[0];
}
const arr2 = [1, 2, 3];
console.log(firstElement(arr2));
function firstElement2(arr) {
    return arr[0];
}
const arr3 = ["hello", "world"];
console.log(firstElement2(arr3));
function general_firstElement(arr) {
    return arr[0];
}
console.log(general_firstElement(arr2));
console.log(general_firstElement(arr3));
const arr4 = [true, false, false];
// console.log(general_firstElement(arr4))
function genaric_firstElement(arr) {
    return arr[0];
}
let o1 = genaric_firstElement(arr2);
let o2 = genaric_firstElement(arr3);
const arr5 = [1, 2, 3, "str", "test"];
let o3 = genaric_firstElement(arr5);
function myfun(arr, func) {
    return arr.map(func);
}
const mynewArr = ["hel", 'world'];
let o4 = myfun(mynewArr, elem => elem.length);
console.log(o4);
const mydata = ["1", "2", "3"];
console.log(myfun(mydata, n => parseInt(n)));
function lengthComparison(a, b) {
    if (a.length >= b.length) {
        return a;
    }
    return b;
}
var arrr1 = [1, 2, 3];
var arrr2 = [1, 2, 5, 6, 7];
console.log(lengthComparison(arrr1, arrr2));
const myuser1 = {
    users: ['a', 'b', 'c'],
    length: 3
};
const myuser2 = {
    users: ['a', 'b'],
    length: 2
};
console.log(lengthComparison(myuser1, myuser2));
console.log(lengthComparison("hhhh", 'xxxx'));
//Utilities
let p2 = {};
let p3 = {
    fname: '',
    lname: '',
    salary: 0
};
// p2.salary=5
// console.log(p2.salary)
// p2.fname = 'test'
// console.log(p2.fname)
let p = {
    fname: 'ahmed',
    lname: 'mohamed',
};
// p.fname = "xyz"
console.log(p.fname);
console.log(p.salary);
let std1 = {
    fname: 'ali',
    // lname:''
};
let std2 = {
    fname: 'xyz',
    lname: 'abc'
};
std2.lname = "dfdsfd";
let deptSec = "HR";
let deptSec2 = "HR";
let deptSec3 = "Dev";
