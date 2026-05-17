import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MyHeader } from "./components/my-header/my-header";
import { MySlider } from "./components/my-slider/my-slider";
import { MyTaskProject } from "./components/my-task-project/my-task-project";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, MyHeader, MySlider, MyTaskProject],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('Task');
}
