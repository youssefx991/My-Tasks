var canvas = document.getElementById('myCanvas')
var context = canvas.getContext('2d')

// context.font = "26pt Georgia"
// context.strokeText("This is a canvas Demo",0,100)
// context.fillText("This is a canvas Demo",0,300)

//shadwing--search

// context.arc(300,150,50,0,2*Math.PI)
// context.arc(300,150,50,Math.PI,-Math.PI)
// context.stroke()

//Gradient
// //Linear
// var grd = context.createLinearGradient(0,0,200,100)
// grd.addColorStop(0,'blue')
// grd.addColorStop(0.5,'yellow')
// grd.addColorStop(1,'green')
// context.fillStyle = grd
// context.fillRect(0,0,300,200)
// context.beginPath()
// context.moveTo(0,0)
// context.lineTo(200,100)
// // context.closePath()
// context.stroke()

// var grd2 = context.createLinearGradient(0,300,0,500)
// grd2.addColorStop(0,'orange')
// grd2.addColorStop(0.4,'yellow')
// grd2.addColorStop(1,'red')
// // context.fillStyle = 'red'
// context.fillStyle = grd2
// context.fillRect(0,300,200,200)

// context.fillRect(350,100,200,200)


//Radial
// var grd = context.createRadialGradient(75,50,20,90,60,100)
// grd.addColorStop(1,'red')
// grd.addColorStop(0,'blue')

// context.fillStyle=grd
// context.fillRect(0,0,200,100)

// // context.arc(75,50,20,0,2*Math.PI)
// // context.stroke()
// // context.arc(90,60,100,0,2*Math.PI)
// // context.stroke()

// context.fillRect(350,400,100,100)

//one-transofrmation matrix
// context.translate(200,250)
// context.rotate(Math.PI/2)
// context.translate(-200,-250)
// context.fillRect(100,200,200,100)
// // context.translate(-100,-200)
// context.setTransform(1,0,0,1,0,0)
// context.fillStyle='red'
// context.fillRect(0,0,50,50)





context.beginPath()
context.moveTo(0,0)
context.lineTo(100,100)
context.strokeStyle='red'
context.lineWidth = 5
context.stroke()
context.save()//
context.translate(100,100)
context.beginPath()
context.moveTo(5,5)
context.lineTo(100,100)
context.strokeStyle = 'yellow'
context.stroke()
// context.restore()
context.beginPath()
context.moveTo(10,10)
context.lineTo(10,100)
context.stroke()

//Web Worker API








































