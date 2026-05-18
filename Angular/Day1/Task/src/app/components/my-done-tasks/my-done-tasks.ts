import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Task } from '../../types';

@Component({
  selector: 'app-my-done-tasks',
  imports: [],
  templateUrl: './my-done-tasks.html',
  styleUrl: './my-done-tasks.css',
})
export class MyDoneTasks {
  data : Task[] = [];

  @Input()
  set TasksFromList(tasks: Task[]) {
    this.data = tasks.filter(task => task.isDone);
  }

  @Output() SendUpdatedTaskIDToList = new EventEmitter<string>();

  markAsDone(task: Task) {
    task.isDone = true;
  }

  updateTask(task: Task) {
    this.SendUpdatedTaskIDToList.emit(task.id);
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
