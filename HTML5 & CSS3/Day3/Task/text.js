var canvas;
var context;
document.body.onload = function() {
    canvas = document.getElementById('canvas')
    context = canvas.getContext('2d')
    const img = document.getElementById('img_bird')

    context.beginPath()
    context.drawImage(img, 0, 0)
    context.closePath()


    context.beginPath();
    context.font = '40px Arial'
    context.shadowBlur = 7
    context.shadowColor = 'black'
    context.fillStyle = 'red'
    context.strokeStyle = 'black'
    context.lineWidth=2;
    context.fillText('Its gonna be okay sweetheart', 10, 300)
    context.shadowBlur = 0
    context.strokeText('Its gonna be okay sweetheart', 10, 300)
    context.closePath()



}