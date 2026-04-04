document.body.onload = function() {
    const canvas = document.getElementById('canvas')
    const context = canvas.getContext('2d')

    
    const gradient1 = context.createLinearGradient(300, 0, 300, 300)
    gradient1.addColorStop(0, 'lightblue')
    gradient1.addColorStop(1, 'white')
    context.fillStyle = gradient1
    context.fillRect(0, 0, canvas.width, canvas.height/2)
    // context.strokeRect(0, 0, canvas.width, canvas.height/2)
    

    const gradient2 = context.createLinearGradient(300, 300, 300, 600)
    gradient2.addColorStop(0, 'lightgreen')
    gradient2.addColorStop(1, 'white')
    context.fillStyle = gradient2
    context.fillRect(0, 300, canvas.width, canvas.height/2)
    // context.strokeRect(0, 300, canvas.width, canvas.height/2)

    const gradient3 = context.createLinearGradient(300, 150, 300, 450)
    gradient3.addColorStop(0, 'black')
    gradient3.addColorStop(1, 'lightgreen')
    
    context.beginPath()
    context.moveTo(150, 150)
    context.lineTo(450, 150)
    context.strokeStyle = gradient3
    context.lineWidth = 5
    context.stroke()
    context.closePath()

    context.beginPath()
    context.moveTo(150, 150)
    context.lineTo(150, 400)
    context.strokeStyle = gradient3
    context.lineWidth = 5
    context.stroke()
    context.closePath()

    context.beginPath()
    context.moveTo(450, 150)
    context.lineTo(450, 400)
    context.strokeStyle = gradient3
    context.lineWidth = 5
    context.stroke()
    context.closePath()
}