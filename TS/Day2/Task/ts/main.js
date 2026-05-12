import { GameManager } from "./managers/GameManager.js";
document.addEventListener("DOMContentLoaded", () => {
    const game = new GameManager();
    game.start();
    document.getElementById("restart-btn")?.addEventListener("click", () => {
        game.restart();
    });
});
