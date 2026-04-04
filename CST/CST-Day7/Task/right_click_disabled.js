console.log("js file loaded");

window.onload = function(){
    
    window.addEventListener("contextmenu", function(event){
        event.preventDefault();
        alert("right click disabled");
    });
    
};