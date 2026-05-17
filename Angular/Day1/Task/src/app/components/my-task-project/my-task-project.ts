import { Component } from '@angular/core';
import { MyTaskForm } from "../my-task-form/my-task-form";
import { MyTaskList } from "../my-task-list/my-task-list";

@Component({
  selector: 'app-my-task-project',
  imports: [MyTaskForm, MyTaskList],
  templateUrl: './my-task-project.html',
  styleUrl: './my-task-project.css',
})
export class MyTaskProject {}
