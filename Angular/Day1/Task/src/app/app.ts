import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MyHeader } from "./components/my-header/my-header";
import { MySlider } from "./components/my-slider/my-slider";
import { MyTaskProject } from "./components/my-task-project/my-task-project";
import { Task } from './types';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, MyHeader, MySlider, MyTaskProject],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('Task');
  AppTasks: Task[] = [
    new Task('Task 1', 'Description for Task 1'),
    new Task('Task 2', 'Description for Task 2'),
    new Task('Task 3', 'Description for Task 3'),
    new Task('Task 4', 'Description for Task 4'),
    new Task('Task 5', 'Description for Task 5'),
    new Task('Task 6', 'Description for Task 6'),
    new Task('Task 7', 'Description for Task 7'),
    new Task('Task 8', 'Description for Task 8'),
    new Task('Task 9', 'Description for Task 9'),
    new Task('Task 10', 'Description for Task 10'),
    new Task('Task 11', 'Description for Task 11'),
    new Task('Task 12', 'Description for Task 12'),
    new Task('Task 13', 'Description for Task 13'),
    new Task('Task 14', 'Description for Task 14'),
    new Task('Task 15', 'Description for Task 15'),
    new Task('Task 16', 'Description for Task 16'),
    new Task('Task 17', 'Description for Task 17'),
    new Task('Task 18', 'Description for Task 18'),
    new Task('Task 19', 'Description for Task 19'),
    new Task('Task 20', 'Description for Task 20'),

  ]

  ReceiveTaskFromProject(TaskFromProject: Task) {
    this.AppTasks.push(TaskFromProject);
    // console.log(this.AppTasks);
  }
}
