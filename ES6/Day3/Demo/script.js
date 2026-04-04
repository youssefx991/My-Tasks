/**
 * classes
 * modules
 * proxy
 * ajax
 * promises
 */

var obj={
    nm:'ahmed',
    age:20,
    display:function(){
        return this.nm
    }
}
var obj2={
    nm:'ali',
    age:25,
    display:function(){
        return this.nm
    }
}
var obj3={
    nm:'mohamed',
    age:15,
    display:function(){
        return this.nm
    }
}

// function person(name,age){
//     this.nm = name
//     this.age = age
//     // this.display = function(){
//     //     return this.nm
//     // }
// }
// var p1 = new person('xyz',1)
// person.prototype.display = function(){
//     return this.nm
// }

// var nm
class Person{
    // let x =1//error
    nm = '...'
    // age=0
    address = "123st"
    #id
    constructor(name="....",age=0){
        if(this.constructor==Person){
            throw 'Abstract class'
        }
        this.nm = name
        this.age = age
        this.#id = 1
        // this.display = function(){
        //     return this.nm
        // }
        Person.count++
    }

    get ID(){
        return this.#id
    }
    set ID(value){
        this.#id = value
    }


    display(msg){
        if(typeof msg == 'string')
        return this.nm+":::"+this.#id
    else
        return this.age
    }

    // toString(){
    //     return `this is ${this.nm}`
    // }

    static count = 0
    static myfun(obj){
        // console.log(this)
        // return Person.count
        return obj.nm
    }
}

class Employee extends Person{

    constructor(name,age,salary){
        super(name,age)
        this.salary = salary
        // this.#id=1
        
    }

    display(){
        // return this.salary
        return super.display()
    }
}

var emp = new Employee('ali',20,100)
var p1 = new Person('xyz',1)
var p2 = new Person()
// console.log(p1.#id)
Person.prototype.fun=function(){
    // return this.#id
    return this.nm
}























