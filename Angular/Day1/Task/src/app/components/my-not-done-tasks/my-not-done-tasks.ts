import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Task } from '../../types';

@Component({
  selector: 'app-my-not-done-tasks',
  imports: [],
  templateUrl: './my-not-done-tasks.html',
  styleUrl: './my-not-done-tasks.css',
})
export class MyNotDoneTasks {
  data: Task[] = [];
  originalData: Task[] = [];

  @Input()
  set TasksFromList(tasks: Task[]) {
    this.originalData = tasks;
    this.data = tasks.filter(task => !task.isDone);
  }

  @Output() SendUpdatedTaskIDToList = new EventEmitter<string>();

  markAsDone(task: Task) {
    this.originalData.find(t => t.id === task.id)!.isDone = true;
    task.isDone = true;
    this.data = this.data.filter(task => !task.isDone);
  }

  updateTask(task: Task) {
    this.SendUpdatedTaskIDToList.emit(task.id);
  }

  markAsNotDone(task: Task) {
    this.originalData.find(t => t.id === task.id)!.isDone = false;
    task.isDone = false;
  }

  deleteTask(task: Task) {
    const index = this.data.indexOf(task);
    if (index > -1)
      this.data.splice(index, 1);

    const originalIndex = this.originalData.findIndex(t => t.id === task.id);
    if (originalIndex > -1)
      this.originalData.splice(originalIndex, 1);
  }
}
