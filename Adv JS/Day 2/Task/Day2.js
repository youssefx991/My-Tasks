function SequenceList(start, end, step) {
    if (start > end || step <= 0)
        throw new Error("start should be less than end, and step be positive");
    // private
    let list = [];

    function fill() {
        let i = 0;
        for (let n = start; n <= end; n += step) {
            list[i++] = n;
        }
    }

    fill();

    function exists(value) {
        return list.includes(value);
    }

    // public
    this.append = function (value) {
        let n = list.length;
        if (exists(value)) {
            throw new Error("Cannot append - value already exists");
        }
        else if (n == 0 || ((list[n - 1] + step) == value)) {
            list.push(value);
        } else {
            throw new Error("Cannot append - value not in order");
        }
    }

    this.prepend = function (value) {
        let n = list.length;
        if (exists(value)) {
            throw new Error("Cannot prepend - value already exists");
        }
        else if (n == 0 || ((list[0] - step) == value)) {
            list.splice(0, 0, value);
        } else {
            throw new Error("Cannot prepend - value not in order");
        }
    }


    this.pop = function () {
        let n = list.length;
        if (n == 0) {
            throw new Error("Cannot pop - list is empty");
        }
        else {
            list.pop();
        }
    }

    this.dequeue = function () {
        let n = list.length;
        if (n == 0) {
            throw new Error("Cannot dequeue- list is empty");
        }
        else {
            list.splice(0, 1);
        }
    }

    this.toString = function () {
        return list.join(" -> ");
    }

    this.valueOf = function () {
        return list.length;
    }

};

function Book(title, numofChapters, author, numofPages, publisher, numofCopies) {
    // public
    this.title = title;
    this.numofChapters = numofChapters;
    this.author = author;
    this.numofPages = numofPages;
    this.publisher = publisher;
    this.numofCopies = numofCopies;
}

function Box(height, width, length, numOfBooks, volume, material, content) {
    // private
    numOfBooks = content.length;

    // public
    this.countBooks = function () {
        // let sum = 0;
        // for (let i=0; i<content.length; i++){
        //     sum += content[i].numofCopies;
        // }

        // return sum;

        return content.length;
    }

    this.deleteBook = function (title) {
        for (let i = 0; i < content.length; i++) {
            if (content[i].title == title) {
                if (content[i].numofCopies <= 1) {
                    content.splice(i, 1);
                    numOfBooks--;
                }
                else
                    content[i].numofCopies--;
                return;
            }
        }
    }

    this.addBook = function (book) {
        numOfBooks++;
        for (let i = 0; i < content.length; i++) {
            if (content[i].title == book.title) {
                content[i].numofCopies++;
                return;
            }
        }

        content.push(book);
    }

    this.toString = function () {
        let books = "[ ";
        for (let i = 0; i < content.length; i++) {
            books += content[i].title + " ";
        }
        books += "]";
        return `Box Dimensions (HxWxL - Volume - Material): ${height} X ${width} X ${length} - ${volume} - ${material}\n 
        Books: ${books}\n`
    }

    this.valueOf = function () {
        return content.length;
    }
}



function TestBoxofBooks() {


    let book1 = new Book(
        "JavaScript",
        10,
        "Ali",
        300,
        "TechPress",
        1
    );

    let book2 = new Book(
        "HTML",
        6,
        "Ahmed",
        200,
        "WebBooks",
        1
    );

    let book3 = new Book(
        "CSS",
        8,
        "Sara",
        250,
        "DesignHouse",
        1
    );

    let box1 = new Box(10, 20, 30, 0, 100, "Wood", []);
    let box2 = new Box(5, 10, 15, 0, 1000, "Plastic", []);

    box1.addBook(book1);
    box1.addBook(book2);
    box1.addBook(book3);
    box1.addBook(book1);
    box1.deleteBook("HTML");

    box2.addBook(book2);

    console.log(box1.toString());
    console.log(box2.toString());

    console.log("box1 + box2 = ", box1 + box2);
}

var SettersGettersGenerator = {
    getSetGen: function () {
        for (var prop in this) {
            if (typeof this[prop] == 'function') continue;

            (function (p, obj) { // Immediately Invoked Function Expression (IIFE)

                var propName = p.charAt(0).toUpperCase() + p.slice(1);

                obj["get" + propName] = function () {
                    return obj[p];
                }.bind(obj);

                obj["set" + propName] = function (value) {
                    this[p] = value;
                }.bind(obj);
            })(prop, this);


        }
    }
}

var user = {
    name: "Ali",
    age: 10
};

var obj = {
    id: "SD-10",
    location: "SV",
    addr: "123 st."
}


SettersGettersGenerator.getSetGen.apply(user);
SettersGettersGenerator.getSetGen.apply(obj);

