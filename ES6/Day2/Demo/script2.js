// /**Collections
//  * Arrays
//  * Object
// Set & Map 
// //Set--unique values
// */
// // var myset = new Set([4,5,6,1,4,5,9])
// // myset.add(1)
// // myset.add(1)
// // myset.add("str")
// // myset.add({})
// // myset.add([1,2,3])
// // myset.add([1,2,3])
// // var arr = [1,2,3]
// // myset.add(arr)
// // myset.add(arr)
// // console.log(Array.from(myset))
// // console.log(myset.values())
// // console.log(myset.keys())
// // console.log(myset.entries())

// // for(var elem in myset){
// //     console.log(elem)
// // }
// // for(var i =0;i<myset.size;i++){
// //     console.log(myset[i])
// // }
// // for(var elem of myset){
// //     console.log(elem)
// // }
// // console.log(myset)
// // myset.forEach(elem=>{
// //     console.log(elem)
// // })

// // console.log(myset.has(1))
// // console.log(myset.has(4))



// var myMap = new Map()
// myMap.set("xyz",'hello')
// myMap.set({},5)
// myMap.set([1,2,3],{nm:'he'})
// myMap.set(3,6)
// myMap.set(3,1)
// // console.log(myMap)

// // console.log(myMap.get(3))
// // console.log(myMap.get("xyz"))

// // for(var [key,value] of myMap){
// //     console.log(key,value)
// // }

// // var arr = [1,2,3,4,5,6,7,8,9]
// // for(var elem of {nm:'ali',age:20}){
// //     console.log(elem)
// // }
// var myObj = {
//     nm:'ali',
//     age:20,
//     address:"123st",

//     [Symbol.iterator]:function(){
//         var index = 0
//             var keys = Object.keys(this)//['nm','age','address']
//             return {
//                 next:function(){
//                 if(index<keys.length){
//                     return {value:keys[index++],done:false}
//                 }
//                 else{
//                     return {value:undefined,done:true}
//                 }
//             }
//             }
//     }
// }

// for(var elem of myObj){
//     console.log(elem)
// }

// function myfun(obj){
//     var index = 0
//     var keys = Object.keys(obj)//['nm','age','address']
//     return {
//         next:function(){
//         if(index<keys.length){
//             return {value:keys[index++],done:false}
//         }
//         else{
//             return {value:undefined,done:true}
//         }
//     }
//     }
//     // return 
// }





// var x = Symbol('Address')
// var y = Symbol()
// console.log(x)
// console.log(typeof x)

// var myObj={
//     name:"Obj",
//     testValue:'test',
//     [x]:'xyz'
// }



var str = "hello world demo"
console.log(str.replace(' ','_'))//
console.log(str.replace(/ /g,'_'))

// String.prototype.replace = function(obj,char){
//     // return 'hello'
//     if(!obj[Symbol.replace])
//         obj[Symbol.replace](this,char)
//     else
//         return this
// }
var myObj={
    usrnm:"myObj",
    fun:function(){},
    [Symbol.replace]:function(str,char){
        return str+'hello'
    }
}

console.log(str.replace(myObj))
console.log(str.replace(' ','_'))//
console.log(str.replace(/ /g,'_'))
// console.log(str.replace({xyz:'123'},'h'))























