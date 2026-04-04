function *fun(x,y){
    var sum = x+y
    // return sum
    yield sum

    console.log('sum ',sum)
    console.log('test 2nd step')
    var arr = [1,2,3,4]
    arr.push(sum)
    yield arr
    // return arr

    var str = 'new string demo'
    str = str.replace('n','-')
    // return str
    yield str
    console.log('done')

}


// function fun1(x,y){
//     var sum = x+y
//   return sum
// }
// function fun2(){
//     console.log('sum ',sum)
//     console.log('test 2nd step')
//     var arr = [1,2,3,4]
//     arr.push(sum)

//     // return arr
// }
// var index = 0
// function outerfun(x,y){
//     // if(index==0){
//     //     sum = fun1(x,y)
//     //     index++
//     // }
//     // if(index == 1){
//     //     fun2()
//     // }

//     fun1()
// }





var arr=[1,2,3,3,4,5,7,8,12,14,7,3,1]
function* evenGen(arr){
    for(var i=0;i<arr.length;i++){
        if(arr[i]%2==0){
            yield arr[i]
        }
    }
}

var iter = evenGen(arr)
console.log(iter.next())//{value:2,done:false}
console.log(iter.next())//{value:2,done:false}
console.log(iter.next())//{value:2,done:false}
console.log(iter.next())//{value:2,done:false}
console.log(iter.next())//{value:2,done:false}
console.log(iter.next())//{value:2,done:false}



// for(var elem of evenGen(arr)){
//     console.log(elem)
// }


// {}
// {courseName:''}
// {courseName:'',courseDuration:''}
// {courseName:'',courseDuration:'',courseOwner:''}


// {value:{key:'nm',value:'ali'},done:false}







