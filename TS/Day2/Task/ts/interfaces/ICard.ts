export interface ICard 
{
    id: number;
    image: string;
    isFlipped: boolean;
    isMatched: boolean;

    flip(): void
    unflip(): void
    match(): void
    
}