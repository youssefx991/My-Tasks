
// 1- Create an interface User with properties name (string) and age (number). and it is required not optional 
//    required create an object with only the name property. 
interface User {
    name: string;
    age: number;
}
let user1: Pick<User, "name"> = {
    name: "Youssef"
};

// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// 2- Create an interface Profile with optional properties username (string) and email (string).
//    required create an object with both properties.
interface Profile {
    username?: string;
    email?: string;
}

let profile1: Required<Profile> = {
    username: "youssef",
    email: "youssef@example.com"
};


// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// 3- Use Record to create an object where keys are "red", "green", and "blue", 
// and values are their corresponding hex color codes (strings). 
//    Test by accessing the red key.
// ----------------------------------------------------------------------------------------------------------------------------------------------------------
type Keys = "red" | "green" | "blue";
type Values = string;

let colors : Record<Keys, Values> = {
    red:  "#FF0000" ,
    green:  "#00FF00" ,
    blue:  "#0000FF"
}

console.log(colors.red);

// 4- Create an interface Person with properties name (string), age (number), and email (string).
//    create a new type with only the name and email properties.
//    Test by creating an object with these properties.
interface Person {
    name: string;
    age: number;
    email: string;
}

let Person1: Pick<Person, "name" | "email"> = {
    name: "Youssef",
    email: "youssef@example.com"
};

console.log(Person1);

// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// 5- Use the same Person interface from the previous question.
//    create a new type without the age property.
//    Test by creating an object with only name and email.
let Person2: Omit<Person, "age"> = {
    name: "Youssef",
    email: "youssef@example.com"
};
console.log(Person2);

// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// 6- Create a union type Colors = "red" | "green" | "blue" | "yellow".
//   create a new type without "yellow".
//   Test by assigning a value of the new type.
type Colors = "red" | "green" | "blue" | "yellow";
type ColorsWithoutYellow = Exclude<Colors, "yellow">;
let color1: ColorsWithoutYellow = "red";
// let color2: ColorsWithoutYellow = "yellow"; // error
console.log(color1);




// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// 7- Use the same Colors union type from the previous question.
//    create a new type with only "red" and "blue".
//    Test by assigning a value of the new type.
type ColorsWithRedAndBlue = Extract<Colors, "red" | "blue">;
let color3: ColorsWithRedAndBlue = "red";
let color4: ColorsWithRedAndBlue = "blue";
console.log(color3);
console.log(color4);

// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// 8- Create a union type MaybeString = string | null | undefined.
//    create a new type without null or undefined.
//    Test by assigning a value of the new type.
// ----------------------------------------------------------------------------------------------------------------------------------------------------------
type MaybeString = string | null | undefined;
type MaybeStringWithoutNullOrUndefined = Exclude<MaybeString, null | undefined>;
let maybeString1: MaybeStringWithoutNullOrUndefined = "Hello, World!";
console.log(maybeString1);

// let maybeString2: MaybeStringWithoutNullOrUndefined = null; // error
// console.log(maybeString2);
