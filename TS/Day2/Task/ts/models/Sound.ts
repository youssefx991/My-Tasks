import { ISound } from "../interfaces/ISound.js";

export class Sound implements ISound
{
    name: string;
    private audio: HTMLAudioElement;
    constructor(name: string)
    {
        this.name = name;
        this.audio = new Audio(`assets/audio/${name}.mp3`);
    }

    play(): void {
        this.audio.currentTime = 0;
        this.audio.play();
    }
    stop(): void {
        this.audio.pause();
        this.audio.currentTime = 0;
    }
}