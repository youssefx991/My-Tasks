
var add=function (){
    console.log(arguments)
    // sum
}
console.log("6 = "+ add.length)
add(1,2,3,4,5,6)
console.log("8 = "+ add.length)

/**apply,call,bind */

var str = 'hello world'
// console.log(str.join())
console.log([].join.apply(str,['*','-']))
console.log([].join.call(str,'*'))

// var res = [].join.bind(str)
// console.log(res('&'))

console.log([].toReversed.apply(str))//reverse



linkedList={
    data:[{val:5}]
}



[{val:3},{val:5},{val:7}]
// linkedList.insert(2,1)

linkedList.remove(5,1)