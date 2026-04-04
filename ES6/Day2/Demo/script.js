// var [x,y]={nm:'ali',age:20}
// var {nm:usrnm,age:test}={nm:'ali',age:20}

// var x = 1
// var y = 2
// var [y,x] =[1,2]
/**
 * default parameters
 * Collection Map&Set
 * iterator
 * Symbol
 * generator
 */
function fun(x=1,y,obj){
    var deafultObj = {
        nm:'xyz',
        age:1
    }
    // if(!obj.nm){
    //     obj.nm = deafultObj.nm
    // }
    // for(var elem in deafultObj){
    //     if(!obj[elem]){
    //         obj[elem]=deafultObj[elem]
    //     }
    // }
    // var result = {...deafultObj,...obj}
    var result = Object.assign({},deafultObj,obj)
    console.log(result)
    // return `x+y`
    return `objName = ${result.nm} and age = ${result.age}`
    // return `objName = ${obj.nm} and age = ${obj.age}`
}
// console.log(fun(1,2,{nm:'ali',age:20}))//3
console.log(fun(1,2,{usrnm:'ahmed',age:20}))//3
console.log(fun(1,2,{}))//3
console.log(fun(1,2,1))//3
console.log(fun(1,2,"str"))//3
console.log(fun(1,2,null))//3
console.log(fun(1,2))//3


// console.log(fun("str","str"))//strstr
// console.log(fun("str",true))//strtrue
// console.log(fun({},{}))//
// console.log(fun(1,true))//2
// console.log(fun(1,null))
// console.log(fun(1))//NaN
// console.log(fun())
// console.log(fun("xnn"))
// console.log(fun(undefined,3))