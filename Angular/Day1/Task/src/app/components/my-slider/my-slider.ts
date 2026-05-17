import { Component } from '@angular/core';

@Component({
  selector: 'app-my-slider',
  imports: [],
  templateUrl: './my-slider.html',
  styleUrl: './my-slider.css',
})
export class MySlider {
  images: string[] = [
    'Barca/1.jpg',
    'Barca/2.jpg',
    'Barca/3.jpg',
    'Barca/4.jpg',
    'Barca/5.jpg',
    'Barca/6.jpg'
  ];

  currentIndex: number = 0;

  interval : any = null;

  nextImage(): void {
    if (this.currentIndex < this.images.length - 1)
      this.currentIndex++;
  }

  prevImage(): void {
    if (this.currentIndex > 0)
      this.currentIndex--;
  }

  changeImage(index: number): void {
    this.currentIndex = index;
  }

  startSlider(): void {
    this.interval = setInterval(() => {
      this.currentIndex = (this.currentIndex + 1) % this.images.length;
    }, 2000);
  }

  stopSlider(): void {
    clearInterval(this.interval);

  }
}


