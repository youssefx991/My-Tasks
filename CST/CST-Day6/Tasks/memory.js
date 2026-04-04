let images = [
    [
        "TaskResources/memory Game/2.gif",
        "TaskResources/memory Game/6.gif",
        "TaskResources/memory Game/3.gif",
        "TaskResources/memory Game/5.gif"
    ],
    [
        "TaskResources/memory Game/4.gif",
        "TaskResources/memory Game/1.gif",
        "TaskResources/memory Game/1.gif",
        "TaskResources/memory Game/2.gif"
    ],
    [
        "TaskResources/memory Game/6.gif",
        "TaskResources/memory Game/5.gif",
        "TaskResources/memory Game/3.gif",
        "TaskResources/memory Game/4.gif"
    ]
]

let image_to_pos = {
    "TaskResources/memory Game/1.gif": [[1, 1], [1, 2]],
    "TaskResources/memory Game/2.gif": [[0, 0], [1, 3]],
    "TaskResources/memory Game/3.gif": [[0, 2], [2, 2]],
    "TaskResources/memory Game/4.gif": [[1, 0], [2, 3]],
    "TaskResources/memory Game/5.gif": [[0, 3], [2, 1]],
    "TaskResources/memory Game/6.gif": [[0, 1], [2, 0]]
};

let opened_images = [
    [false, false, false, false],
    [false, false, false, false],
    [false, false, false, false]
];

let moon_image = "TaskResources/memory Game/Moon.gif";

let first_clicked_image = null;
let first_clicked_image_row = null;
let first_clicked_image_col = null;
let curr_row;
let curr_col;
let timeout_animation = false;

function click_img(clicked_image) {
    if (timeout_animation) return;
    curr_row = Number(clicked_image.id.split('')[0]);
    curr_col = Number(clicked_image.id.split('')[1]);
    
    if (opened_images[curr_row][curr_col]) // clicked already opened image
        return;
    
    if (clicked_image == first_clicked_image) // clicked same image twice
        return;
   
    clicked_image.src = images[curr_row][curr_col];
    opened_images[curr_row][curr_col] = true;

    if (first_clicked_image == null) { // click order (0, 2, 4, ...)
        first_clicked_image = clicked_image;
        first_clicked_image_row = curr_row;
        first_clicked_image_col = curr_col;
        return;
    }


    if (first_clicked_image.src != clicked_image.src) { // not like each other
        timeout_animation = true;
        let img1 = first_clicked_image;
        let r1 = first_clicked_image_row;
        let c1 = first_clicked_image_col;

        let img2 = clicked_image;
        let r2 = curr_row;
        let c2 = curr_col;
        setTimeout(function () {
            img1.src = moon_image;
            img2.src = moon_image;
            opened_images[r1][c1] = false;
            opened_images[r2][c2] = false;
            timeout_animation = false;
        }, 1000);
    } else if (is_all_opened()) { // like each other
            setTimeout(() => {
                alert('You won');
                reset_game();

            }, 500);
            return;
        }
    first_clicked_image = null;
    first_clicked_image_row = null;
    first_clicked_image_col = null;
}

function is_all_opened() {
    for (let i = 0; i < 3; i++) {
        for (let j = 0; j < 4; j++) {
            if (!opened_images[i][j])
                return false;
        }
    }

    return true;
}

function reset_game(){
    let curr_images = document.getElementsByTagName("img");
    for (let i=0; i<curr_images.length; i++){
        curr_images[i].src = moon_image;
    }

    opened_images = [
        [false, false, false, false],
        [false, false, false, false],
        [false, false, false, false]
    ];

    first_clicked_image = null;
    first_clicked_image_row = null;
    first_clicked_image_col = null;
}

function shuffle_images(){
    
}