"use strict";
let user1 = {
    name: "Youssef"
};
let profile1 = {
    username: "youssef",
    email: "youssef@example.com"
};
let colors = {
    red: "#FF0000",
    green: "#00FF00",
    blue: "#0000FF"
};
console.log(colors.red);
let Person1 = {
    name: "Youssef",
    email: "youssef@example.com"
};
console.log(Person1);
// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// 5- Use the same Person interface from the previous question.
//    create a new type without the age property.
//    Test by creating an object with only name and email.
let Person2 = {
    name: "Youssef",
    email: "youssef@example.com"
};
console.log(Person2);
let color1 = "red";
// let color2: ColorsWithoutYellow = "yellow"; // error
console.log(color1);
let color3 = "red";
let color4 = "blue";
console.log(color3);
console.log(color4);
let maybeString1 = "Hello, World!";
console.log(maybeString1);
// let maybeString2: MaybeStringWithoutNullOrUndefined = null; // error
// console.log(maybeString2);
