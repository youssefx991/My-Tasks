
// Task 1
console.log("Task 1 - Passing Object\n\n");

function task1(obj = {}) {
    let defaultObj = {
        courseName: "ES6",
        courseDuration: "3days",
        courseOwner: "JavaScript"
    }
    for (let key of Object.keys(obj)) {
        if (!(key in defaultObj))
            throw new Error(`Passed Object contains invalid key : ${key}`);
    }

    obj = Object.assign({}, defaultObj, obj);

    console.log(obj);

}


let courseObj1 = {}

let courseObj2 = { courseName: "CN2" }

let courseObj3 = { courseName: "CN3", courseDuration: "3days", }

let courseObj4 = { courseName: "CN4", courseDuration: "4days", courseOwner: "Object4" }

let courseObj5 = { courseName: "CN5", courseDuration: "5days", courseOwner: "Object5", coursePrice: 255 };



try {
    task1(courseObj1)
    task1(courseObj2)
    task1(courseObj3)
    task1(courseObj4)
    task1(courseObj5)
}
catch (error) {
    console.log(error.message);
}



// Task 2
console.log("\n\nTask 2 - Fibonacci\n\n");

function* fib_count(count) {
    let first = 0;
    let second = 1;


    for (let i = 1; i <= count; i++) {
        if (i == 1)
            yield first
        else if (i == 2)
            yield second
        else {

            let third = first + second;
            yield third

            first = second;
            second = third;
        }
    }
}

function* fib_max(value) {
    let first = 0;
    let second = 1;

    if (first <= value)
        yield first
    if (second <= value)
        yield second

    while (first + second <= value) {
        let third = first + second
        yield third

        first = second
        second = third
    }
}

console.log("using count = 10");
for (let n of fib_count(10))
    console.log(n);

console.log("using max = 100");
for (let n of fib_max(100))
    console.log(n);



// Task 3
console.log("\n\nTask 3 - Replace\n\n");
let replaceObj = {
    [Symbol.replace]: function (str) {
        if (str.length <= 15)
            return str;
        else
            return str.substring(0, 15) + "...";
    }
}

let replaceStr1 = "Sky is blue.";
let replaceStr2 = "The weather today is absolutely wonderful.";

console.log(replaceStr1.replace(replaceObj))
console.log(replaceStr2.replace(replaceObj))


// Task 4
console.log("\n\nTask 4 - Iterable\n\n");
let iterableObj = {
    id: 1,
    name: "youssef",
    age: 24,
    [Symbol.iterator]: function* () {
        let keys = Object.keys(this)
        for (let key of keys) {
            // yield {
            //     value: {
            //         key: key,
            //         value: this[key]
            //     },
            //     done: false
            // }

            yield { key: key, value: this[key] };

        }

        // yield {
        //     value: undefined,
        //     done: true
        // };

    }
}

for (let elem of iterableObj)
    console.log(elem);


