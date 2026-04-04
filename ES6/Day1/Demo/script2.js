//Arrow Function


// function fun(x,y){
//     console.log(this)
//     return x+y
// }

// fun(1,2)

// var obj={
//     nm:'ahmed',
//     display:function(){
//         return this.nm
//     }
// }
// obj.display()//implicit binding

// var obj={
//     nm:'ahmed',
//     display:function(){
//         console.log(this)//obj
//         //this---->obj
//         // var that = this
//         setTimeout(()=>{
//             alert(this.nm)
//         },2000)
//         // myfun(1,2)
//     },
//     printfun:()=>{
//         console.log(this)//window
//         return this.nm
//     }
// }
// // obj.display()
// console.log(obj.printfun())



// function myfun(){
//     function test(){
//         return 'hello'
//     }
// }




// var myfun = (x,y)=> {
//     console.log(this)
//     return x+y
// }
// console.log(myfun(1,2))

//lexical binding
/**
 * default binding
 * implicit binding
 * explicit binding
 * hard binding
 */


var myfun = ()=>{
    console.log(this)
}

var fun = function(){
    console.log(this)
}


fun()
var myobj={
    testfun:myfun,
    logfun:fun
}

var myobj2={
    display:fun
}

myobj.testfun()//
myobj.logfun()//

















