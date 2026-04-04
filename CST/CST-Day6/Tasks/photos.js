let imgs = [
    "TaskResources/SlideShow/1.jpg",
    "TaskResources/SlideShow/2.jpg",
    "TaskResources/SlideShow/3.jpg",
    "TaskResources/SlideShow/4.jpg",
    "TaskResources/SlideShow/5.jpg",
    "TaskResources/SlideShow/6.jpg",
];
let curr_idx = 0;
let slideshow_interval;
// let curr_img = document.getElementById("img");


function click_previous(){
    if (curr_idx > 0){
        curr_idx--;
        document.getElementById("img").src = imgs[curr_idx];
    }
}

function click_next(){
    if (curr_idx < imgs.length - 1){
        curr_idx++;
        document.getElementById("img").src = imgs[curr_idx];
    }
}

function click_slideshow(){
    if (!slideshow_interval){
        slideshow_interval = setInterval(function(){
            curr_idx = (curr_idx + 1) % imgs.length;
            document.getElementById("img").src = imgs[curr_idx];
    
        }, 2000);
    }
}


function click_stop(){
    if (slideshow_interval){
        clearInterval(slideshow_interval);
        slideshow_interval = null;
    }
}
