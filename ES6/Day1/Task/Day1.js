
// Task 1
console.log("Swapping\n\n");
let x = 10;
let y = 20;
console.log(`Before Swapping x=${x} \t y=${y}`);

[x, y] = [y, x];

console.log(`After Swapping x=${x} \t y=${y}`);



// Task 2
console.log("\n\nFinding Max and Min\n\n");
function Task2_spread(numbers) {


    const max = Math.max(...numbers);

    const min = Math.min(...numbers);

    return [min, max];
}
function Task2_rest_spread(...numbers) {


    const max = Math.max(...numbers);

    const min = Math.min(...numbers);

    return [min, max];
}




let numbers = [5, 10, 2, 88, 15];
const [min1, max1] = Task2_spread(numbers);
const [min2, max2] = Task2_rest_spread(...numbers);
console.log(`Numbers: ${numbers}`);
console.log(`Using spread operator only : Min = ${min1}, Max = ${max1}`);
console.log(`Using rest and spread operator: Min = ${min2}, Max = ${max2}`);



// Task 3
console.log("\n\nArray API\n\n");

let fruits = ["apple", "strawberry", "banana", "orange", "mango"];
console.log(`Fruits: ${fruits}`);

let AllString = fruits.every(fruit => typeof fruit === "string");
console.log(`All elements are strings: ${AllString}`);

let StartWithA = fruits.some(fruit => fruit.startsWith("a"));
console.log(`At least one element starts with "a": ${StartWithA}`);


let StartWithBOrS = fruits.filter(fruit => fruit.startsWith("b") || fruit.startsWith("s"));
console.log(`Elements that start with "b" or "s": ${StartWithBOrS}`);

let ILikeFruits = fruits.map(fruit => `I like ${fruit}`);
console.log(`Elements that I like: ${ILikeFruits}`);


console.log("Displaying using foreach:");
ILikeFruits.forEach(fruit => console.log(fruit));