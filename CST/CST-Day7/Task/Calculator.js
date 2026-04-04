function EnterNumber(value) {
    document.getElementById("Answer").value += value;
}

function EnterOperator(value) {
    document.getElementById("Answer").value += value;
}


function EnterClear() {
    document.getElementById("Answer").value = '';
}

function EnterEqual() {
    let result;
    let answer = document.getElementById("Answer").value;
    EnterClear();
    try {
        result = eval(answer);
        document.getElementById("Answer").value = result;
    } catch (e) {
        alert("invalid expression");
    }
}
