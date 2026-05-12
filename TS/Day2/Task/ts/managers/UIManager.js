export class UIManager {
    gameBoard = document.getElementById("game-board");
    movesElement = document.getElementById("moves");
    timerElement = document.getElementById("timer");
    scoreElement = document.getElementById("score");
    renderCards(cards, onclick) {
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
        });
    }
    flipCard(element) {
        element.classList.add("flip");
    }
    unflipCard(element) {
        element.classList.remove("flip");
    }
    updateMoves(moves) {
        if (this.movesElement)
            this.movesElement.textContent = moves.toString();
    }
    updateTimer(time) {
        if (this.timerElement)
            this.timerElement.textContent = time.toString();
    }
    updateScore(score) {
        if (this.scoreElement)
            this.scoreElement.textContent = score.toString();
    }
}
