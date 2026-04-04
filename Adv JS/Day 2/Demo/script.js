/**Inner Function */

// var x = 1
// var z = 2
// var h = 1 
// var y = 0
// function outerFun(x,y){
//     console.log(arguments)
//     var z = 1//shadwing
//     function innerFun(a,b){
//         // console.log(outerFun.arguments)//null
//         return x+y+a+b+z+h
//     }
//     z++
//     return innerFun
// }

// // var x = 1
// // var y = 1
// var res = outerFun(1)//
// // var res2 = outerFun(2,2)
// console.log(res(1,2))


// function outerFun(){
//     var x = 1
//     function innerFun1(){
//         var y = 1
//         function inner2(){
//             var z = 1
//             function inner3(){
//                 var w = 1
//                  console.log(x+y+z+w)
//             }
//             inner3()
//         }
//         inner2()
//     }
//     innerFun1()
//     x = 5
// }
// var outerFunRes = outerFun()


function outerFun(){
    var arr=[]
    for(var i =0;i<3;i++){
        (function(j){
            arr.push(function(){
                // let j = i
                console.log(j)
            })

        })(i)
    }
    return arr
}

// var res = outerFun()//[f,f,f]
// res[0]()
// res[1]()
// res[2]()

var obj = {
    nm:'ali',
    age:25,
    address:'123st',
    display:function(){
        return this.nm
    }
}

var obj2 = {
    nm:'ahmed',
    age:21,
    address:'xyz',
    display:function(){
        return this.nm
    }
}

var obj3 = {
    nm:'mohamed',
    age:26,
    address:'abc',
    display:function(){
        return this.nm
    }
}

/**
 * Factory Method
 * Constructor Function
 */
//Factory Method
function Employee2(nm,id,salary){
    return {
        nm:nm,
        id:id,
        sal:salary,
        display:function(){
            return this.nm
        }
    }
}

var myObj = Employee2('ali',123,1)
// var emp2 = Employee('ahmed',123,1)
// var emp3 = Employee('mohamed',123,1)

// //Constructor Function
// function Employee(nm="",id=0,sal){
//     let usrnm = nm//private variable
//     //private property
//     // this.nm = nm
//     this.id = id //|| 0
//     this.salary = sal//?sal:100
//     // return "hello"
//     this.getUsrnm = function(){
//         return usrnm
//     }
//     this.setUsrnm = function(val){
//         usrnm = val
//     }
//     this.toString = function(){
//         return 'this is '+usrnm+" and id "+this.id
//     }
//     this.valueOf = function(){
//         return this.salary
//     }
//     this.display = function(msg){
//         if(msg){
//             return usrnm
//         }
//         else{
//             return this.id
//         }
//     }
//     Employee.count++
// }
// Employee.count = 0
// Employee.staticFun = function(obj){
//     // return this.count
//     // return Employee.count
//     return obj.id
// }
// xyz = 1
// console.log(xyz)

// var emp = new Employee('ali',123,10000)
// var emp2 = new Employee('ahmed',111,2000)
// var emp4 = new Employee()
// console.log(usrnm)



// function fun(x,y){
//     return x+y
// }

// function fun(x,y,z){
//     return x+y+z
// }

//closure problem---this
// var myObj = {
//     usrnm:'ahmed',
//     age:20,
//     display:function(){
//         console.log(this)
//         var that = this
//         setTimeout(function(){
//             alert(that.usrnm)
//         },2000)
//     }
// }

// myObj.display()




// function myfun(fun,time){
//     //
//     //
//     //
//     // delay time
//     fun()
// }



//default binding--window object
// function myfun(){
//     console.log(this)
// }

// myfun()

//implicit binding
// var obj = {
//     usrnm:'xyz',
//     display:function(){
//         console.log(this)
//     }
// }

// obj.display()//implicit binding

// function fun(){
//     console.log(this.val)
// }
// function myfun(){
//     console.log(this)
//     var val = "myVal"
//     this.val = "myNewVal"
//     this.fun = fun
//     this.fun()
//     fun()
// }

// var val = 'globalVal'
// var myObj = new myfun()
// console.log(val)
//myNewVal-globalVal2
//myNewVal-myVal2
//myNewVal2-globalVal







function Employee(nm,id){
    this.nm = nm
    this.id = id
    var welcome = function(){
        alert(this.nm)
    }
    this.welcome()
    //explicit binding
    // welcome.call(this)
    // welcome.apply(this)
    // var res = welcome.bind(this)
    // res()
}

var emp = new Employee('Ahmed',123)
var emp2 = new Employee('Ahmed',123)







































