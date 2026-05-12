export class Card {
    id;
    image;
    isFlipped;
    isMatched;
    constructor(id, image, isFlipped = false, isMatched = false) {
        this.id = id;
        this.image = image;
        this.isFlipped = isFlipped;
        this.isMatched = isMatched;
    }
    flip() {
        this.isFlipped = !this.isFlipped;
    }
    unflip() {
        this.isFlipped = false;
    }
    match() {
        this.isMatched = true;
    }
}
