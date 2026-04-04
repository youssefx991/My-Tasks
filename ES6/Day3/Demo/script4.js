//AJAX
//1)create instance xhr
document.getElementById('btn').onclick = function(){

    var id = document.getElementById('num').value

var xhr = new XMLHttpRequest()
console.log(xhr.readyState)//0

xhr.onreadystatechange = function(){
    console.log(xhr.readyState)
    if(xhr.readyState==4){
        console.log(xhr.status)
        if(xhr.status>=200&&xhr.status<300){
            // console.log(xhr.status)
            // console.log(xhr.responseText)
            // console.log(JSON.parse(xhr.responseText))
            var data =JSON.parse(xhr.responseText)
            /**
             * one product--id
             * all products
             */
            console.log(data)
                if(data.products){
                    for(var i=0;i<data.products.length;i++){
                        document.getElementById('h1id').innerHTML += data.products[i].title+"<br>"
                        // document.getElementById('h1id').innerHTML += data[i].name+"<br>"
                    }
                }
                else{
                        document.getElementById('h1id').innerHTML += data.title+"<br>"

                }
        }
        /**product not found */
        else{
                document.getElementById('h1id').innerHTML ="Product Not found"

        }
    }

}
//2)define method,url
//
xhr.open('GET','https://dummyjson.com/products/'+id)
// xhr.open('GET','std.json')
// xhr.open('GET','textfile.txt')

//3)send request
xhr.send()

}