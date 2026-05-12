import { Card } from "../models/Card.js";
import { UIManager } from "./UIManager.js";
import { AudioManager } from "./AudioManager.js";
import { TimerManager } from "./TimerManager.js";
import { CardsNames } from "../models/CardsNames.js";
import { ShuffleArray } from "../Utils/ShuffleUtility.js";

export class GameManager
{
    cards : Card[] = [];
    ui : UIManager = new UIManager();
    audio : AudioManager = new AudioManager();
    timer : TimerManager = new TimerManager();
    firstCard: Card | null = null;
    firstELement: HTMLElement | null = null;
    secondCard: Card | null = null;
    secondElement: HTMLElement | null = null;
    moves: number = 0;
    score: number = 0;
    locked: boolean = false;
    matchedPairs: number = 0;
    firstClick: boolean = true;

    start() : void 
    {
        this.createCards();
        this.ui.renderCards(this.cards, (element, card) => this.handleCardClick(element, card));
    }
    createCards() : void
    {
        const duplioted = [...CardsNames, ...CardsNames];
        const shuffled = ShuffleArray(duplioted);
        this.cards = shuffled.map((name, index) => new Card(index, name));
    }

    handleCardClick(element: HTMLElement, card: Card) : void
    {
        if (this.firstClick) {
            this.timer.start((time) => this.ui.updateTimer(time));
            this.audio.fulltrack.play();
            this.firstClick = false;
        }
        if (this.locked || card.isFlipped || card.isMatched) return;
        this.ui.flipCard(element);
        card.flip();
        this.audio.flip.play();

        if (!this.firstELement) {
            this.firstCard = card;
            this.firstELement = element;
            return;
        }
        
        this.secondCard = card;
        this.secondElement = element;
        
        this.moves++;
        this.ui.updateMoves(this.moves);
        if (this.moves >= 30 && this.matchedPairs < CardsNames.length) {
            this.loseGame();
            return;
        }
        this.checkMatch();

    }

    checkMatch() : void
    {
        if (this.firstCard?.image === this.secondCard?.image) {
            this.handleSuccess();
        } else {
            this.handleFail();
        }
    }

    handleSuccess() : void
    {
        this.firstCard?.match();
        this.secondCard?.match();
        this.audio.good.play();
        this.matchedPairs++;
        this.score += 10;
        this.ui.updateScore(this.score);
        this.resetTurn();
        if (this.matchedPairs === CardsNames.length)
            this.winGame();
    }

    handleFail(): void
    {
        this.locked = true;
        this.audio.fail.play();
        setTimeout(() => {
            if (this.firstELement)
            {
                this.ui.flipCard(this.firstELement);
                this.firstCard?.unflip();
            }
            if (this.secondElement)
            {
                this.ui.flipCard(this.secondElement);
                this.secondCard?.unflip();
            }

            this.ui.unflipCard(this.firstELement!);
            this.ui.unflipCard(this.secondElement!);

            this.resetTurn();
        }, 1000);
    }
    resetTurn() : void
    {
        this.firstCard = null;
        this.secondCard = null;
        this.firstELement = null;
        this.secondElement = null;
        this.locked = false;
    }
    

    winGame() : void
    {
        this.audio.good.play();
         alert(`
            You Won!

            Moves: ${this.moves}

            Score: ${this.score}

            Time: ${this.timer.getTime()}s
        `);
    }

    loseGame() : void
    {
        this.audio.fulltrack.stop();
        this.audio.gameover.play();
        alert(`
            Game Over!
            
            Moves: ${this.moves}
            
            Time: ${this.timer.getTime()}s
            `);
        this.restart();
    }

    restart() : void
    {
        this.cards = [];
        this.firstCard = null;
        this.secondCard = null;
        this.firstELement = null;
        this.secondElement = null;
        this.moves = 0;
        this.score = 0;
        this.locked = false;
        this.matchedPairs = 0;
        this.timer.reset();
        this.audio.fulltrack.stop();
        this.firstClick = true;
        this.ui.updateMoves(this.moves);
        this.ui.updateTimer(this.timer.getTime());
        this.ui.updateScore(this.score);
        this.start();
    }

}