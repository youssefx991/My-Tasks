var obj={
    x:10,
    y:"xyz"
}

// obj.x = 10
// obj.z = 2
// console.log(obj.z)//undefined
var handler = {
    get(target,prop){
        if(target.hasOwnProperty(prop)){
            return target[prop]
        }
        else{
            throw 'undefined property'
        }
    }
    ,set(target,prop,value){
        if(target.hasOwnProperty(prop)){
            if(prop=='x'){
           if(value>=10&&value<=30){
            target[prop]=value
           }
           else{
            throw 'wrong value'
           }}
           else if(prop=='y'){
            if(typeof value=='string'){
                target[prop]=value
            }
            else{
                throw 'wrong datatype'
            }
           }
        }
        else{
            throw 'non-exist property'
        }
    }

}

var myproxy = new Proxy(obj,handler)
console.log(myproxy.x)
console.log(myproxy.z)



