function task1_1() {
    let n = Number(prompt("Enter array size ( > 0)"));
    let arr = []
    while (isNaN(n) || n <= 0) {
        alert("Please enter only positive numbers ( > 0)");
        n = Number(prompt("Enter array size ( > 0)"));
    }


    for (let i = 0; i < n; i++) {
        let num = Number(prompt(`Enter number in position ${i + 1}`));
        while (isNaN(num)) {
            alert("Please enter only numbers");
            num = Number(prompt(`Enter number in position ${i + 1}`));
        }
        arr[i] = num;
    }

    // < 0  a => b
    // > 0  b => a
    // = 0  keep order
    console.log(`Sorted ascendingly: ${arr.toSorted(function (a, b) { return Number(a) - Number(b) })}`); 
    console.log(`Sorted descendengly: ${arr.toSorted(function (a, b) { return Number(b) - Number(a) })}`); 


}

function showAddr(address) {
    if (address.street == undefined || address.buildingNum == undefined || address.city == undefined) {
        return "required keys not found";
    }
    let today = new Date();
    today = today.toLocaleDateString().split(",")[0];
    let result = `${address.buildingNum} ${address.street}, ${address.city} registered in ${today}`;

    return result;
}

function dispVal(obj, prop){
    if (obj[prop] == undefined){
        return "didn't find required property";
    }

    if (prop == "age")
        return `${obj[prop]} years old`;
    else if (prop == "nm")
        return `name is ${obj[prop]}`
    else 
        return `obj[${prop}] = ${obj[prop]}`
}

function task1_3_area(){
    let radius = Number(prompt('enter value of radius')); 
    while (isNaN(radius) || radius < 0){
        alert("enter only positive numbers");
        radius = Number(prompt('enter value of radius'));
    }
    alert(`area of circle = ${Math.PI * radius * radius}`)
}

function task1_3_sqrt(){
    let value = Number(prompt('enter value of positive number to find its square root')); 
    while (isNaN(value) || value < 0){
        alert("enter only  positive numbers");
        value = Number(prompt('enter value of number to find its square root'));
    }
    alert(`square root of ${value} = ${Math.sqrt(value)}`)
}

function task1_3_angle(){
    let angle = Number(prompt('enter value of angle in degrees to find its cos')); 
    while (isNaN(angle)){
        alert("enter only numbers");
        angle = Number(prompt('enter value of angle in degrees to find its cos')); 
    }
    console.log(`cosine  of ${angle} = ${Math.cos(angle * (Math.PI / 180))}`);
}

let win = null;
let move_interval = null;
let direction = 1;
let win_y= 0;

const step = 10;
const win_width = 300;
const win_height = 200;

function onclick_open() {
    setTimeout(open_window, 1000);
}

function open_window() {
    if (!win || win.closed) {
        win = window.open(
            "child.html",
            "moving_window",
            `width=${win_width},height=${win_height}`
        );
       win_y= 0;
    }

    toggle_movement();
}

function toggle_movement() {
    if (!win || win.closed) return;

    // if moving => stop
    if (move_interval) {
        clearInterval(move_interval);
        move_interval = null;
        return;
    }

    // if stopped => start
    move_interval = setInterval(() => {
        if (!win || win.closed) {
            clearInterval(move_interval);
            move_interval = null;
            return;
        }

        
        win.focus();
        win.moveTo(1000, win_y);

       win_y+= step * direction;

        if (win_y <= 0 || win_y + win_height + 80 >= screen.availHeight) {
            direction *= -1;
        }
    }, 50);
}

function close_window() {
    if (move_interval) {
        clearInterval(move_interval);
        move_interval = null;
    }
    if (win && !win.closed) {
        win.close();
    }
}

function open_adv_window() {
    let adv_win = window.open(
        "child2.html",
        "advertising_window",
        "width=400,height=300,scrollbars=yes"
    );

    let adv_direction = 1;
    let adv_step = 5;

    let scrolling_interval = setInterval(() => {
        if (!adv_win || adv_win.closed) {
            clearInterval(scrolling_interval);
            scrolling_interval = null;
            return;
        }

        adv_win.scrollBy(0, adv_step * adv_direction);

        if (adv_win.innerHeight + adv_win.scrollY > adv_win.document.body.scrollHeight) {
            clearInterval(scrolling_interval);
            adv_win.close();
        }

    }, 50);
}
