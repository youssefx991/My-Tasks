class Polygon {
    l1;
    l2;

    constructor(l1, l2) {
        if (this.constructor == Polygon)
            throw "cannot create instances of Polygon class";

    }
    get Area() {
        throw "cannot get area of base class polygon";
    }

    toString() {
        return `Polygon: L1=${this.l1} L2=${this.l2}`;
    }

    Draw() {
        throw "cannot draw base class polygon";
    }
}

class Rectangle extends Polygon {
    constructor(length = 0, width = 0) {
        super();
        this.l1 = length;
        this.l2 = width;
    }

    get Area() {
        return this.l1 * this.l2;
    }

    toString() {
        return `Rectangle: Length=${this.l1} Width=${this.l2} Area=${this.Area}`;
    }

    Draw(startX = 0, startY = 0) {
        context.beginPath();
        context.fillStyle = 'red'
        context.fillRect(startX, startY, this.l2, this.l1);
        context.closePath();
    }
}

class Square extends Polygon {
    constructor(length = 0) {
        super();
        this.l1 = length;
    }

    get Area() {
        return this.l1 * this.l1;
    }

    toString() {
        return `Square: Length=${this.l1} Area=${this.Area}`;
    }

    Draw(startX = 300, startY = 0) {
        context.beginPath();
        context.fillStyle = 'green'
        context.fillRect(startX, startY, this.l1, this.l1);
        context.closePath();
    }
}

class Circle extends Polygon {
    constructor(radius = 0) {
        super();
        this.l1 = radius;
    }

    get Area() {
        return Math.PI * this.l1 * this.l1;
    }

    toString() {
        return `Circle: Radius=${this.l1} Area=${this.Area}`;
    }

    Draw(startX = 100, startY = 450) {
        context.beginPath();
        context.fillStyle = 'blue';
        context.arc(startX, startY, this.l1, 0, 2 * Math.PI);
        context.stroke();
        context.fill();
        context.closePath();
    }
}

class Triangle extends Polygon {
    constructor(base = 0, height = 0) {
        super();
        this.l1 = base;
        this.l2 = height;
    }

    get Area() {
        return 0.5 * this.l1 * this.l2;
    }

    toString() {
        return `Triangle: Base=${this.l1} Height=${this.l2} Area=${this.Area}`;
    }

    Draw(startX = 300, startY = 300) {

        context.beginPath();
        context.fillStyle = 'orange';
        context.moveTo(startX, startY);
        context.lineTo(startX, startY + this.l2);
        context.lineTo(startX + this.l1, startY + this.l2)
        context.lineTo(startX, startY);
        context.stroke();
        context.fill();
        context.closePath();
    }
}

let canvas = document.getElementById('canvas');
let context = canvas.getContext('2d');


let r = new Rectangle(100, 200);
let s = new Square(100);
let c = new Circle(100);
let t = new Triangle(100, 200);

let polygons = [r, s, c, t]
for (let p of polygons) {
    console.log(p.toString());
    p.Draw();
}

// for(let i=0; i<polygons.length; i++)
// {
//     console.log(polygons[i].toString());
//     polygons[i].Draw(0, i*300);
// }



let obj = {
    name: "N/A",
    address: "N/A",
    age: 30
}


let handler = {
    set(target, prop, value) {
        if (!target.hasOwnProperty(prop))
            throw `Property ${prop} does not exist on this object.`;
        switch (prop) {
            case 'name':
                if (typeof value != 'string' || value.length != 7)
                    throw "Name must be a string of exactly 7 characters.";
                break;
            case 'address':
                if (typeof value !== 'string') {
                    throw "Address must be a string.";
                }
                break;
            case 'age':
                if (typeof value !== 'number' || value < 25 || value > 60) {
                    throw "Age must be a number between 25 and 60.";
                }
                break;
        }

        target[prop] = value
    }
}
let proxy = new Proxy(obj, handler);

// work
proxy.name = 'youssef'
proxy.address = 'my address'
proxy.age = 30

// throw error
// proxy.name = 'ahmed'
// proxy.name = 123;

// proxy.address = 132;

// proxy.age = 24

