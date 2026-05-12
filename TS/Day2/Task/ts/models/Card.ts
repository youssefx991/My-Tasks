import { ICard } from "../interfaces/ICard.js";

export class Card implements ICard
{
    id: number;
    image: string;
    isFlipped: boolean;
    isMatched: boolean;
    constructor(id: number, image: string, isFlipped: boolean = false, isMatched: boolean = false)
    {
        this.id = id;
        this.image = image;
        this.isFlipped = isFlipped;
        this.isMatched = isMatched;
    }

    flip(): void
    {
        this.isFlipped = !this.isFlipped;
    }

    unflip(): void
    {
        this.isFlipped = false;
    }
    match(): void
    {
        this.isMatched = true;
    }


}