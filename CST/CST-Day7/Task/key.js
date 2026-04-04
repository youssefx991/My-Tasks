window.onload = function(){
    window.addEventListener("keydown", function(event){
        if (event.ctrlKey && event.key.toLowerCase() === "s"){
            event.preventDefault();
            alert("CTRL + S to save is disabled")
            return;
        }

        if (event.ctrlKey && event.key.toLowerCase() === "p"){
            event.preventDefault();
            alert("CTRL + P to print is disabled")
            return;
        }

        document.getElementById("kd_ck").innerText = "Pressed Character Key (keydown): " + event.key;
        document.getElementById("kd_pk").innerText = "Pressed Physical Key (keydown): " + event.code;
        
    });

    window.addEventListener("keypress", function(event){
        document.getElementById("kp_ck").innerText = "Pressed Character Key (keypress): " + event.key;
        document.getElementById("kp_pk").innerText = "Pressed Physical Key (keypress): " + event.code;
        
        
    });
};