export interface ISound
{
    name : string;
    audioElement: HTMLAudioElement;
    play() : void;
    stop() : void;
}