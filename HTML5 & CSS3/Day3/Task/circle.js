document.body.onload = function () {
    const canvas = document.getElementById('canvas')
    const context = canvas.getContext('2d')

    const gradient1 = context.createLinearGradient(240, 40, 513, 513)
    gradient1.addColorStop(1, 'blue')
    gradient1.addColorStop(0, 'white')

    
    const gradient2 = context.createLinearGradient(480, 510, 40, 90)
    gradient2.addColorStop(1, 'blue')
    gradient2.addColorStop(0, 'white')

    context.beginPath();
    context.arc(300,300,200,0,2*Math.PI)
    context.fillStyle = gradient1;
    context.fill();
    context.closePath();

    context.beginPath();
    context.arc(300,300,150,0,2*Math.PI)
    context.fillStyle = gradient2;
    context.fill();
    context.closePath();
    
    context.beginPath()
    context.font = "300px Arial";
    context.fillStyle = 'white'
    context.fillText("Y", 200, 410);
    context.closePath();
}