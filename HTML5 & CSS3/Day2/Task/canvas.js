
    let x = 0, y = 0;

    let canvas = document.getElementById("canvas");
    let context = canvas.getContext("2d");

    context.beginPath();
    context.strokeStyle = "red";
    context.lineWidth = 5;
    let interval = setInterval(function () {
        if (x > 500 || y > 500) {
            alert("Done");
            clearInterval(interval);
            context.closePath();
            return;
        }
        context.moveTo(0, 0);
        context.lineTo(x, y);
        
        context.stroke();
        x += 1;
        y += 1;
    }, 1);

