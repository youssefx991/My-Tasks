import { GameManager } from "./managers/GameManager.js";

document.addEventListener("DOMContentLoaded", () => {
    const game : GameManager = new GameManager();
    game.start();

    document.getElementById("restart-btn")?.addEventListener("click", () => {
        game.restart();
    });
});