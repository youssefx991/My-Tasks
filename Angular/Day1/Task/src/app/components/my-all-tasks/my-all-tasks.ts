import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Task } from '../../types';

@Component({
  selector: 'app-my-all-tasks',
  imports: [],
  templateUrl: './my-all-tasks.html',
  styleUrl: './my-all-tasks.css',
})
export class MyAllTasks {
  @Input() TasksFromList : Task[] = [];
  @Output() SendUpdatedTaskIDToList = new EventEmitter<string>();


  markAsDone(task: Task) {
    task.isDone = true;
  }

  updateTask(task: Task) {
    console.log("update from all tasks: ", task);
    this.SendUpdatedTaskIDToList.emit(task.id);
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
