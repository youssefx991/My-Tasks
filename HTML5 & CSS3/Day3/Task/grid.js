document.body.onload = function() {
    const canvas = document.getElementById('canvas')
    const context = canvas.getContext('2d')

    const cellSize = 100    


    for (let i = 0; i < 3; i++) {
        for (let j = 0; j < 3; j++) {
            context.strokeRect(60 + j * 140, 40 + i * 200, cellSize, cellSize)
        }
    }
    // context.strokeRect(60, 40, cellSize,  cellSize)
    // context.strokeRect(200, 40, cellSize,  cellSize)
    // context.strokeRect(340, 40, cellSize,  cellSize)

    
    // context.strokeRect(60, 240, cellSize,  cellSize)
    // context.strokeRect(200, 240, cellSize,  cellSize)
    // context.strokeRect(340, 240, cellSize,  cellSize)

    // context.strokeRect(60, 440, cellSize,  cellSize)
    // context.strokeRect(200, 440, cellSize,  cellSize)
    // context.strokeRect(340, 440, cellSize,  cellSize)

    
}