export class Sound {
    name;
    audioElement;
    constructor(name) {
        this.name = name;
        this.audioElement = new Audio(`assets/audio/${name}.mp3`);
    }
    play() {
        this.audioElement.currentTime = 0;
        this.audioElement.play();
    }
    stop() {
        this.audioElement.pause();
        this.audioElement.currentTime = 0;
    }
}
