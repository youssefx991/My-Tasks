function Shape() {
    if (!(this instanceof Rectangle) && !(this instanceof Square))
        throw new Error("ERROR in shape - cannot create instances");
}

Shape.prototype.area = function () {
    throw new Error("ERROR in shape - cannot call area()");
}

Shape.prototype.perimeter = function () {
    throw new Error("ERROR in shape - cannot call perimeter()");
}


let rectangle_counter = 0;
let square_counter = 0;

function Rectangle(Length, Width) {
    if (rectangle_counter == 1 && !(this instanceof Square))
        throw new Error("ERROR in Rectangle - cannot create new objects");
    Shape.call(this);

    if (!(this instanceof Square))
        rectangle_counter++;

    Object.defineProperty(this, "Length", {
        get: function () {
            return Length;
        },
        set: function (L) {
            Length = L;
        }
    });

    Object.defineProperty(this, "Width", {
        get: function () {
            return Width;
        },
        set: function (W) {
            Width = W;
        }
    });
}

Object.setPrototypeOf(Rectangle.prototype, Shape.prototype);
Rectangle.prototype.area = function () {
    return this.Width * this.Length;
}
Rectangle.prototype.perimeter = function () {
    return 2 * (this.Width + this.Length);
}
Rectangle.prototype.toString = function () {
    return `Rectangle (LXW - Area - Perimter): ${this.Length} X ${this.Width} - ${this.area()} - ${this.perimeter()}`;
}
Rectangle.prototype.valueOf = function () {
    return this.area();
}


function Square(Length) {
    if (square_counter == 1)
        throw new Error("ERROR in square - cannot create new objects");
    square_counter++;
    Rectangle.call(this, Length, Length);
}

Object.setPrototypeOf(Square.prototype, Rectangle.prototype);

Square.prototype.toString = function () {
    return `Square (Length - Area - Perimter): ${this.Length} - ${this.area()} - ${this.perimeter()}`;
}


function TestShapes(){
    let r1 = new Rectangle(10, 6); // area=60, perimeter=32
    let s1 = new Square(5); // area = 25, perimeter = 20
    
    console.log(r1.toString());
    console.log(s1.toString());
    
    console.log(r1 + s1); // 60 + 25 = 85
    console.log(r1 - s1); // 35 

    // let r2 = new Rectangle(1,2); // error
    // let s2 = new Square(1); // error
    // let shape = new Shape(); // error


}




function Vehicle(speed, color) {
    let _speed = speed;
    let _color = color;
    Object.defineProperty(this, "speed", {
        get: function () {
            return _speed;
        },
        set: function (value) {
            _speed = value
        }
    });

    Object.defineProperty(this, "color", {
        get: function () {
            return _color;
        },
        set: function (value) {
            _color = value
        }
    });


    this.turnLeft = function () {
        console.log("Turn Left");
    };

    this.turnRight = function () {
        console.log("Turn Right");
    };


    this.star = function () {
        console.log("star");
        return true;
    };

    this.stop = function () {
        console.log("stop");
        return false;
    };


    this.goBackward = function (speed, accel) {
        console.log(`goBackward ${speed} ${accel}`);
        return true;
    };

    this.goForward = function (speed, accel) {
        console.log(`goForward ${speed} ${accel}`);
        return false;
    };


    this.toString = function () {
        return "Vehicle toString()";
    }


    this.valueOf = function () {
        return 1;
    }

}

function MotorVehicle(speed, color, sizeOfEngine, licencePlate) {
    let _sizeOfEngine = sizeOfEngine;
    let _licencePlate = licencePlate;

    Vehicle.call(this, speed, color);
    Object.defineProperty(this, "sizeOfEngine", {
        get: function () {
            return _sizeOfEngine;
        },
        set: function (value) {
            _sizeOfEngine = value
        }
    })
    Object.defineProperty(this, "licencePlate", {
        get: function () {
            return _licencePlate;
        },
        set: function (value) {
            _licencePlate = value
        }
    })


    this.getLicencePlate = function () {
        console.log("getLicencePlate");
        return _licencePlate;
    };

    this.getSizeOfEngine = function () {
        console.log("getSizeOfEngine");
        return _sizeOfEngine
    };

    this.toString = function () {
        return "MotorVehicle toString()";
    }


    this.valueOf = function () {
        return 2;
    }

}

Object.setPrototypeOf(MotorVehicle.prototype, Vehicle.prototype);

function Bicycle(speed, color) {
    Vehicle.call(this, speed, color);

    this.ringBell = function () {
        console.log("ringBell");
    };


    this.toString = function () {
        return "Bicycle toString()";
    }


    this.valueOf = function () {
        return 3;
    }

}

Object.setPrototypeOf(Bicycle.prototype, Vehicle.prototype);

function Car(speed, color, sizeOfEngine, licencePlate, numOfDoors, numWheels, weight) {
    let _numOfDoors = numOfDoors;
    let _numWheels = numWheels;
    let _weight = weight;

    MotorVehicle.call(this, speed, color, sizeOfEngine, licencePlate);

    Object.defineProperty(this, "numOfDoors", {
        get: function () {
            return _numOfDoors;
        },
        set: function (value) {
            _numOfDoors = value
        }
    })
    Object.defineProperty(this, "numWheels", {
        get: function () {
            return _numWheels;
        },
        set: function (value) {
            _numWheels = value
        }
    })
    Object.defineProperty(this, "weight", {
        get: function () {
            return _weight;
        },
        set: function (value) {
            _weight = value
        }
    })


    this.switchOnAir = function () {
        console.log("switchOnAir");
    };

    this.getNumofDoors = function () {
        console.log("getNumofDoors");
    };


    this.toString = function () {
        return "Car toString()";
    }


    this.valueOf = function () {
        return 4;
    }

}

Object.setPrototypeOf(Car.prototype, MotorVehicle.prototype);

function DumpTruck(speed, color, sizeOfEngine, licencePlate, loadCapacity, numWheels, weight) {
    let _loadCapacity = loadCapacity;
    let _numWheels = numWheels;
    let _weight = weight;

    MotorVehicle.call(this, speed, color, sizeOfEngine, licencePlate);

    Object.defineProperty(this, "loadCapacity", {
        get: function () {
            return _loadCapacity;
        },
        set: function (value) {
            _loadCapacity = value
        }
    })
    Object.defineProperty(this, "numWheels", {
        get: function () {
            return _numWheels;
        },
        set: function (value) {
            _numWheels = value
        }
    })
    Object.defineProperty(this, "weight", {
        get: function () {
            return _weight;
        },
        set: function (value) {
            _weight = value
        }
    })


    this.lowerLoad = function () {
        console.log("lowerLoad");
    };

    this.raiseLoad = function () {
        console.log("raiseLoad");
    };


    this.toString = function () {
        return "DumpTruck toString()";
    }


    this.valueOf = function () {
        return 5;
    }

}

Object.setPrototypeOf(DumpTruck.prototype, MotorVehicle.prototype);


function TestUML() {
    let v = new Vehicle(80, "red");
    let mv = new MotorVehicle(120, "black", 2000, "ABC-123");
    let b = new Bicycle(25, "blue");
    let c = new Car(150, "white", 2500, "CAR-999", 4, 4, 1500);
    let d = new DumpTruck(90, "yellow", 5000, "TRK-777", 20, 6, 8000);

    console.log(v.speed);      // 80
    console.log(v.color);      // red

    console.log(mv.sizeOfEngine);   // 2000
    console.log(mv.licencePlate);   // ABC-123

    console.log(c.numOfDoors); // 4
    console.log(d.loadCapacity); // 20

    v.turnLeft();      // Turn Left
    v.turnRight();     // Turn Right

    mv.turnLeft();     // inherited
    b.turnRight();     // inherited
    c.turnLeft();      // inherited
    d.turnRight();     // inherited

    b.ringBell();        // ringBell

    c.switchOnAir();    // switchOnAir
    c.getNumofDoors();  // getNumofDoors

    d.lowerLoad();      // lowerLoad
    d.raiseLoad();     // raiseLowed (typo but works)

    v.goForward(60, 5);      // goForward 60 5
    v.goBackward(40, 3);    // goBackward 40 3

    mv.goForward(100, 10);
    c.goBackward(80, 4);

    console.log(v.toString());   // Vehicle toString()
    console.log(mv.toString());  // MotorVehicle toString()
    console.log(b.toString());   // Bicycle toString()
    console.log(c.toString());   // Car toString()
    console.log(d.toString());   // DumpTruck toString()

    console.log(c instanceof Car);          // true
    console.log(c instanceof MotorVehicle); // true
    console.log(c instanceof Vehicle);      // true

    console.log(b instanceof Bicycle);      // true
    console.log(b instanceof Vehicle);      // true
    console.log(b instanceof MotorVehicle); // false


}