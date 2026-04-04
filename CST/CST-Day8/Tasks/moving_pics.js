window.onload = function () {
    let left_img = document.getElementById("left_img");
    let right_img = document.getElementById("right_img");
    let bottom_img = document.getElementById("bottom_img");

    let left_pos = 0;
    let right_pos = 550;
    let bottom_pos = 350;

    let left_dir = 1;
    let right_dir = -1;
    let bottom_dir = -1;
    let interval = null;

    let go_stop_btn = document.getElementById("go_stop_btn");
    go_stop_btn.onclick = function () {
        if (go_stop_btn.value === "Go") {
            interval = setInterval(function () {

                left_pos += left_dir;
                if (left_pos >= 550 || left_pos <= 0) left_dir *= -1;
                left_img.style.left = left_pos + "px";

                right_pos += right_dir;
                if (right_pos >= 550 || right_pos <= 0) right_dir *= -1;
                right_img.style.left = right_pos + "px";

                bottom_pos += bottom_dir;
                if (bottom_pos >= 350 || bottom_pos <= 0) bottom_dir *= -1;
                bottom_img.style.top = bottom_pos + "px";

                document.getElementById("style1").innerText = left_img.outerHTML;
                document.getElementById("style2").innerText = right_img.outerHTML;
                document.getElementById("style3").innerText = bottom_img.outerHTML;

            }, 10);

            go_stop_btn.value = "Stop";
        } else {
            clearInterval(interval);
            interval = null;
            go_stop_btn.value = "Go";
        }
    };

    let reset_btn = document.getElementById("reset_btn");
    reset_btn.onclick = function () {
        clearInterval(interval);
        interval = null;

        left_pos = 0;
        right_pos = 550;
        bottom_pos = 350;

        left_dir = 1;
        right_dir = -1;
        bottom_dir = -1;

        left_img.style.left = left_pos + "px";
        right_img.style.left = right_pos + "px";
        bottom_img.style.top = bottom_pos + "px";

        go_stop_btn.value = "Go";
    };
};
