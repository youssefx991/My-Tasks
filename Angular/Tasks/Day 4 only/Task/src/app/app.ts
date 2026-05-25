import { Component } from '@angular/core';
import { MyHeader } from "../components/my-header/my-header";
import { MySlider } from "../components/my-slider/my-slider";
import { MyTaskProject } from "../components/my-task-project/my-task-project";

@Component({
  selector: 'app-root',
  imports: [MyHeader, MySlider, MyTaskProject],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {}
