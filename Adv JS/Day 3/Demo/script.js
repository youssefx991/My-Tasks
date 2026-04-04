// // const obj = {
// //     usrnm:'ali',
// //     age:20,
// //     display:function(){
// //         return this.usrnm
// //     }
// // }

// // console.log(obj)
// // obj.address = '123st'

// // for(var elem in obj){
// //     console.log(elem)
// // }


// /**data Descriptor
//  * {
//  * value:undefined,
//  * writable:false,
//  * enumerable:false,
//  * configurable:false
//  * }
//  * 
//  * Accessor descriptor
//  * {
//  * get:function,
//  * set:function,
//  * enumerable:false,
//  * configurable:false
//  * }
//  */

// var myObj = {
//     testData:'prop'
// }
// Object.defineProperty(myObj,'usrnm',{
//     value:'ali',
//     writable:false,
//     enumerable:true,
//     configurable:false
// })
// Object.defineProperty(myObj,'age',{
//     value:25,
//     writable:false,
//     enumerable:false,
//     configurable:true
// })

// var add = '123'
// Object.defineProperty(myObj,'address',{
//     // value:2,//error
//     // get:function(){
//     //     return add
//     // },
//     set:function(val){
//         add=val
//     },
//     enumerable:true,
//     configurable:true
// })

// for(var elem in myObj){
//     console.log(elem)
// }

// //can't add new Property
// // Object.preventExtensions(myObj)
// // console.log(myObj)
// // myObj.xyz = 1
// // console.log(myObj)


// //can't add new Property
// //non-configurable
// // Object.seal(myObj)


// //can't add new Property
// //non-configurable
// //non-writable
// Object.freeze(myObj)

// function display(){
//     return this.nm+"::"+this.age
// }
function User(nm,age){
    console.log(this)
    // if(!(this instanceof Employee)){
    //     throw 'error'
    // }
    if(this.constructor == User){
        throw 'error'
    }
    //var Id = 1//private variable
    //privilage methods
    this.nm = nm
    this.age = age
}
User.prototype.toString = function(){
    return 'welcome '+this.nm
}

function Employee(nm,age,id){
    User.call(this,nm,age)//

    var Id = id
    this.nm = 'my Employee'
    // Object.defineProperty(this,'nm',{
    //     value:nm,
    // })

    // Object.defineProperty(this,'age',{
    //     value:age
    // })
    Object.defineProperty(this,'Id',{
        get:function(){
            return Id
        },
        set:function(val){
            Id = val
        }
    })
    // Object.defineProperty(this,'display',{
    //     value:display,
    //     /*function(){
    //         return this.nm+"::"+this.age
    //     },*/
    //     // writable:false
    //     // get:function(){
    //     //     return function(){
    //     //         return this.nm+"::"+this.age
    //     //     }
    //     // }
    //     enumerable:false
    // })
    // Object.preventExtensions(this)
}
// Employee.prototype.nm = "hi"
// Object.setPrototypeOf(Employee.prototype,User.prototype)
Employee.prototype = Object.create(User.prototype)
Employee.prototype.constructor = Employee
Employee.prototype.testProp = 'newProp'
Employee.prototype.display = function(){
    console.log(this)
    return this.nm+"::"+this.age
}
var emp = new Employee('Ahmed',20,1)
var emp2 = new Employee('Ali',20,1)
var emp3 = new Employee('Mohamed',20,1)
// emp.count = 0
// var u1 = new User('ali',5)
Employee.prototype.testfun = function(){
    return 'hi'
}


var obj = {
    nm:'ahmed',
    age:20
}

var myObj = {
    address:"123st",
    dept:'sd'
}


// class Person{
//     public string name
//     public int age
//     Person(nm,age){
//         name = nm
//         age = age
//     }
// }

// class Student{
//     public int id
//     Student(nm,age,id):Person(nm,age){

//     }
// }

// Student xyz = new Student('ali',10,1)
// xyz.nm








