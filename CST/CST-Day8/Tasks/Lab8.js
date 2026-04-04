document.getElementById("cookies_btn").onclick = function(){
    document.location.href = "register.html";
}

document.getElementById("moving_pics_btn").onclick = function(){
    document.location.href = "moving_pics.html";
}
document.getElementById("paragraph_btn").onclick = function(){
    document.location.href = "paragraph.html";
}





function error1(){
    if (arguments.length != 2){
        throw new Error("ERROR - Parameters length does not equal 2, it is ", arguments.length);
    }
}

function error2(){
    if (arguments.length == 0){
        throw new Error("ERROR - no parameters passed")
    }
    let sum = 0;
    for (let i=0; i<arguments.length; i++){
        if (typeof arguments[i] != 'number'){
            throw new Error("ERROR - only numbers are allowed");
        }
        sum += arguments[i];
    }

    return sum;
}