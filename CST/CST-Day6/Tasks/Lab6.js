function click_wait(){
    wait5sec(function(){
        alert("5 seconds passed");
    });

}

function wait5sec(cb){
    let ms = Date.now();
    let seconds = Math.floor(ms / 1000);
    while (true){
        let new_ms = Date.now();
        let new_seconds = (new_ms / 1000);
        if (new_seconds - seconds >= 5) break;
    }

    cb();
}


function open_typing_window(){
    window.open("typing_window.html", "typing_window", "width=300, height=200");
}

function open_form(){
    window.location.assign("register.html");
}



function open_photos(){
    window.location.assign("photos.html");
}

function open_marbles(){
    window.location.assign("marbles.html");
}

function open_memory(){
    window.location.assign("memory.html");
}