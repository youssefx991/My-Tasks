import { Sound } from "../models/Sound.js";

export class AudioManager
{
    fail = new Sound("fail")
    flip = new Sound("flip");
    fulltrack = new Sound("fulltrack");
    gameover = new Sound("game-over");
    good = new Sound("good");
}