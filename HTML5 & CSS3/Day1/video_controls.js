document.body.onload = function () {
    let video = document.getElementById("video");

    document.getElementById("lbl_seek_bar").max = video.duration;

    video.ontimeupdate = function () {
        document.getElementById("bar_seek").value = video.currentTime;
        document.getElementById("lbl_seek_bar").innerText = video.currentTime.toFixed(0) + " / " + video.duration.toFixed(0);
    }

    document.getElementById("btn_play").onclick = function () {
        if (video.paused) {
            video.play();
        }
    }

    document.getElementById("btn_pause").onclick = function () {
        if (!video.paused) {
            video.pause();
        }
    }

    document.getElementById("btn_begin").onclick = function () {
        video.currentTime = 0;
    }

    document.getElementById("btn_end").onclick = function () {
        video.currentTime = video.duration;
    }

    document.getElementById("btn_seek_left").onclick = function () {
        video.currentTime -= 5;
    }

    document.getElementById("btn_seek_right").onclick = function () {
        video.currentTime += 5;
    }

    document.getElementById("btn_mute").onclick = function () {
        video.muted = true;
        document.getElementById("bar_volume").value = 0;
    }
    document.getElementById("bar_seek").oninput = function () {
        video.currentTime = this.value;
    }

    document.getElementById("bar_volume").oninput = function () {
        video.muted = false;
        video.volume = this.value;
    }

    document.getElementById("bar_speed").oninput = function () {
        video.playbackRate = this.value;
    }

}