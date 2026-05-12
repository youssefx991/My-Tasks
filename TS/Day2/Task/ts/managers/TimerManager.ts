export class TimerManager
{
    private seconds: number = 0;
    private interval? : number;
    start(callback: (time: number) => void)
    {
        this.interval = setInterval(() => {
            this.seconds++;
            callback(this.seconds);
        }, 1000);
    }

    reset():void
    {
        this.seconds = 0;
        if (this.interval)
        {
            clearInterval(this.interval);
        }       
    }

    getTime(): number
    {
        return this.seconds;
    }

    pause(): void
    {
        if (this.interval)
        {
            clearInterval(this.interval);
        }
    }
}