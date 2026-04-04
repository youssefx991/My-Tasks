(function(){

    var obj={
        x:'new Value',
        fun:function(){
            return 'hello'
        }
    }
    // window.myObj = obj
    Object.defineProperty(window,'myObj',{
        value:obj
    })
})()