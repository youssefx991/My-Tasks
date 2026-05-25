import { ChangeDetectorRef, Component, OnDestroy, OnInit, inject } from '@angular/core';

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

  interval: ReturnType<typeof setInterval> | null = null;
  private readonly cdr = inject(ChangeDetectorRef);

  changeImage(index: number): void {
    this.currentIndex = index;
  }

  startSlider(): void {
    if (this.interval) {
      clearInterval(this.interval);
    }

    this.interval = setInterval(() => {
      this.currentIndex = (this.currentIndex + 1) % this.images.length;
      this.cdr.detectChanges();
    }, 1000);
  }

  stopSlider(): void {
    if (this.interval) {
      clearInterval(this.interval);
      this.interval = null;
    }

  }

  ngOnInit() {
    this.startSlider();
  }

  ngOnDestroy(): void {
    this.stopSlider();
  }
}


