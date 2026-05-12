import { Card } from "../models/Card.js";

export class UIManager {
    gameBoard = document.getElementById("game-board") as HTMLElement;
    movesElement = document.getElementById("moves") as HTMLElement;
    timerElement = document.getElementById("timer") as HTMLElement;
    scoreElement = document.getElementById("score") as HTMLElement;

    renderCards(cards: Card[], onclick: (element: HTMLElement, card: Card) => void): void {
        this.gameBoard.innerHTML = "";
        cards.forEach((card) => {
            const cardElement = document.createElement("div");
            cardElement.classList.add("memory-card");
            cardElement.innerHTML = `
                <div
                    class="
                        card-inner
                        rounded
                        shadow
                        border
                        border-2
                        border-primary
                    "
                >

                    <div class="card-front">

                        <img
                            src="assets/back.jpg"
                            class="rounded"
                        >

                    </div>

                    <div class="card-back">

                        <img
                            src="assets/images/${card.image}"
                            class="rounded"
                        >

                    </div>

                </div>
                `;
            cardElement.addEventListener("click", () => onclick(cardElement, card));
            this.gameBoard.appendChild(cardElement);
        }
        );
    }

    flipCard(element: HTMLElement): void 
    {
        element.classList.add("flip");
    }

    unflipCard(element: HTMLElement): void
    {
        element.classList.remove("flip");
    }


    updateMoves(moves: number) {
        if (this.movesElement)
            this.movesElement.textContent = moves.toString();
    }
    updateTimer(time: number) {
        if (this.timerElement)
            this.timerElement.textContent = time.toString();
    }
    updateScore(score: number) {
        if (this.scoreElement)
            this.scoreElement.textContent = score.toString();
    }
}