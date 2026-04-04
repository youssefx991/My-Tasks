document.body.onload = function(){
    document.getElementById("btn-email").onclick = function(){
        location.href = "email.html";
    }
    
    document.getElementById("btn-rectangle").onclick = function(){
        location.href = "rectangle.html";
    }
    document.getElementById("btn-circle").onclick = function(){
        location.href = "circle.html";
    }
    document.getElementById("btn-text").onclick = function(){
        location.href = "text.html";
    }
    document.getElementById("btn-grid").onclick = function(){
        location.href = "grid.html";
    }

}

/*
  <input type="button" value="email-page" id="btn-email">
    <input type="button" value="rectangle-page" id="btn-rectangle">
    <input type="button" value="circle-page" id="btn-circle">
    <input type="button" value="text-page" id="btn-text">
    <input type="button" value="grid-page" id="btn-grid">
*/