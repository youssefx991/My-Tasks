import { Component, Input } from '@angular/core';
import { Task } from '../../types';

@Component({
  selector: 'app-my-all-tasks',
  imports: [],
  templateUrl: './my-all-tasks.html',
  styleUrl: './my-all-tasks.css',
})
export class MyAllTasks {
  @Input() TasksFromList : Task[] = [];

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
    const index = this.TasksFromList.indexOf(task);
    if (index > -1)
      this.TasksFromList.splice(index, 1);
  }
}
