// var arr = [1, 2, 3, 4, 5, 'abc']

// var num = 9
// var str = 'abc'
// var a = []
// arr = [1, 2, 3, [44, 55, 66, [888]], 7, , , 1000]

// arr[3][3][0]

// arr.length

// arr[11] = a

// var arr2 = []
// for (let i = 0; i < arr.length; i++) {
//   arr2[i] = arr[i]
// }
// //////

// var hamada = []
// hamada['first name'] = 'Ali'
// hamada['lastName'] = 'kareem'
// hamada['age'] = 10
// hamada['addr'] = '123 st.' //subscript notation

// hamada[0] = 10
// hamada[3] = 50

// var x = 'age'
// console.log(hamada[x])

// for (i = 0; i < hamada.length; i++) console.log(hamada[i])

// for (i in hamada) console.log(hamada[i])

// var obj = {
//   addr: '123 st.'
// }
// obj.firstName = 'ali'
// obj.lastName = 'ahmed'
// obj.age = 10
// obj.skills = ['HTML', 'CSS', 'JS']
// obj.siblings = {
//   first: 'Mona',
//   second: 'kareem',
//   thrid: ''
// }

// obj['firstName']
// obj[x]
// obj.newProp

// obj2[i] = obj[i]

// today.toLocalDateString("ar-eg",{month:'short'})
// 12/2/2026
// 12 apr

// var x = setInterval(function () {
//   clearInterval(x)
// }, ms)

// // function setInterval(cb,ms){
// // //
// // //ms
// // cb()

// // }

console.log('beforeTimeout')

var x = setInterval(function () {
  //
  console.log('timeout')
  clearInterval(x)
}, 2000)
console.log('afterTimeout')
