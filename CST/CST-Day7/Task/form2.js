function displayVal(input){
    document.getElementById("txt1").value += input.value.trim();
}

function eraserFun(){
    let str = document.getElementById("txt1").value;
    document.getElementById("txt1").value = str.substr(0, str.length-1);
}

function clearFun(){
    document.getElementById("txt1").value = '';
}