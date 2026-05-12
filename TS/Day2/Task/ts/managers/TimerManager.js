export class TimerManager {
    seconds = 0;
    interval;
    start(callback) {
        this.interval = setInterval(() => {
            this.seconds++;
            callback(this.seconds);
        }, 1000);
    }
    reset() {
        this.seconds = 0;
        if (this.interval) {
            clearInterval(this.interval);
        }
    }
    getTime() {
        return this.seconds;
    }
    pause() {
        if (this.interval) {
            clearInterval(this.interval);
        }
    }
}
