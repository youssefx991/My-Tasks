import { Component, Input } from '@angular/core';
import { Task } from '../../types';

@Component({
  selector: 'app-my-not-done-tasks',
  imports: [],
  templateUrl: './my-not-done-tasks.html',
  styleUrl: './my-not-done-tasks.css',
})
export class MyNotDoneTasks {
  data: Task[] = [];

  @Input()
  set TasksFromList(tasks: Task[]) {
    this.data = tasks.filter(task => !task.isDone);
  }

  markAsDone(task: Task) {
    task.isDone = true;
  }

  updateTask(task: Task) {
    // Implement the logic to update the task

  }

  markAsNotDone(task: Task) {
    task.isDone = false;
  }

  deleteTask(task: Task) {
    const index = this.data.indexOf(task);
    if (index > -1)
      this.data.splice(index, 1);
  }
}
