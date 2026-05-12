import { ISound } from "../interfaces/ISound.js";

export class Sound implements ISound
{
    name: string;
    audioElement: HTMLAudioElement;
    constructor(name: string)
    {
        this.name = name;
        this.audioElement = new Audio(`assets/audio/${name}.mp3`);
    }

    play(): void {
        this.audioElement.currentTime = 0;
        this.audioElement.play();
    }
    stop(): void {
        this.audioElement.pause();
        this.audioElement.currentTime = 0;
    }
}