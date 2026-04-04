document.body.onload = function () {
    document.getElementById("inp_red").oninput = update;
    document.getElementById("inp_green").oninput = update;
    document.getElementById("inp_blue").oninput = update;

    let p_text = document.getElementById("p_text");

    function update() {
        let r = document.getElementById("inp_red").value;
        let g = document.getElementById("inp_green").value;
        let b = document.getElementById("inp_blue").value;
        p_text.style.color = "rgb(" + r + "," + g + "," + b + ")";
    }
}