// var cb = function () {
//   //
//   console.log('ay 7aga')
// }

// cb()

// var timer = setInterval(function () {
//   //
//   console.log('ay 7aga')

//   clearInterval(timer)
// }, 1000)

// // eval("")

// function adding (x, y) {
//   return x + y
// }

// function fun (a, b) {
//   console.log(a)
//   console.log(b)
//   //
//   //
//   //
// }

// // var y = 55
// // fun(adding(1, 2), y)
// var timerID
// var fun = function () {
//   console.log('timeout fun')

//   timerID = setTimeout(fun, 5000)
//   console.log('timeout fun end')
// }

// // fun()

// // setTimeout(function(){

// //     setTimeout(function(){
// //         set

// //     },2000)
// // },2000)
//single call stack
//no interruption
//non blocking
//single thread

//Asynch behav

//WEB APIS

console.log('start') //1
//1
setTimeout(function () {
  console.log('1') //last
}, 5000)

// function wait10Sec(){

//
// }
// wait10Sec()
//2
setTimeout(function () {
  console.log('2')
}, 1000)

fun()
//4
setTimeout(function () {
  console.log('3') ///////first
}, 0)

function fun () {
  console.log('start function fun') //2
  //3
  setTimeout(function () {
    console.log('timeout inside fun')
  }, 1000)

  console.log('end function fun') //3
}
//5
setTimeout(function () {
  console.log('4')
}, 500)

console.log('end') //4

// function fun(){
//     setTimeout(fun,1000)
// }

// for(0-->3){
//     setTimeout(,0)
// }

// setInterval()
