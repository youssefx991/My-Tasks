let curr_idx = 0;
let animation_interval;

animate();

function animate() {
    if (animation_interval) return;

    animation_interval = setInterval(function () {
        document.getElementById(`m${curr_idx}`).src = "TaskResources/marbels/marble1.jpg"
        curr_idx = (curr_idx + 1) % 5;
        document.getElementById(`m${curr_idx}`).src = "TaskResources/marbels/marble3.jpg"

    }, 500);
}


function on_mouse_over() {
    if (animation_interval){
        clearInterval(animation_interval);
        animation_interval=null;
    }
}

function on_mouse_out() {
    if (!animation_interval){
        animate();
    }
}
