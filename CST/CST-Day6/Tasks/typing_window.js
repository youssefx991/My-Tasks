let msg = "Your message will be displayed character by character :) <br> few seconds and this window will terminate";
let i=0;
let interval = setInterval(function() {
    document.write(msg[i++]);
    if (i == msg.length)
    {
        clearInterval(interval);
        setTimeout(function(){
        close();
        }, 2000);
    }
}, 100);