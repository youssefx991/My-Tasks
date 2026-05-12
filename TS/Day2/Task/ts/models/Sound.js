export class Sound {
    name;
    audio;
    constructor(name) {
        this.name = name;
        this.audio = new Audio(`assets/audio/${name}.mp3`);
    }
    play() {
        this.audio.currentTime = 0;
        this.audio.play();
    }
    stop() {
        this.audio.pause();
        this.audio.currentTime = 0;
    }
}
