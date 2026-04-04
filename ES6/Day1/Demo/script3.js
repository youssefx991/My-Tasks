// /**rest parameter & spread operator */
// function add(x,y,z,...param){
//     console.log(arguments)
//     console.log(param)
//     return x+y+z
// }
// var arr = [1,2,3,4,5]
// console.log(add(1,2,3,...arr))

// /**spread operator ... */


// var arr2=[1,2,3,...arr]
// var myobj={
//     nm:"xyz",
//     age:25
// }
// var myobj2={
//     address:"123st",
//     ...myobj
// }

// function displayName(firstname,lastname){
//     console.log(arguments)
//     return `this is ${firstname} ${lastname}`
// }

// var arr =['ahmed','ali','xyz','test']
// console.log(displayName(...arr))
// // console.log(displayName(arr[0],arr[1]))


/**Desturcturing */

// var arr =[1,2,3,4,5,6,7,8]
// var x = arr[0]//1
// var y = arr[3]//4
// var z = arr[6]//7
// var [x,,,y,,,z]="hello world"
// var x,y,z
//  [x,,,y,,,z]=arr
// var [x,,,y,,,z]={nm:"ali",age:20}


// var myObj = {nm:"ali",age:20,address:"123"}
// var x = myObj.nm
// var y = myObj.address
// var x,y
// ({address:y,nm:x}=myObj)

//Number API

// console.log(isFinite("123"))
// console.log(isFinite("sss"))
// console.log(isFinite(123))
// console.log(isFinite(true))

// console.log(Number.isFinite("123"))
// console.log(Number.isFinite(123))
// console.log(Number.isFinite("fdfdsf"))
// console.log(Number.isFinite(true))

// console.log(isNaN("123"))
// console.log(isNaN("sss"))
// console.log(isNaN(123))
// console.log(isNaN(true))

// console.log(Number.isNaN("123"))
// console.log(Number.isNaN("mdmd"))
// console.log(Number.isNaN(true))
// console.log(Number.isNaN(11111))




















