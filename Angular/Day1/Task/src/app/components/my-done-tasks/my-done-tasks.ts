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
  originalData: Task[] = [];

  @Input()
  set TasksFromList(tasks: Task[]) {
    this.originalData = tasks;
    this.data = tasks.filter(task => task.isDone);
  }

  @Output() SendUpdatedTaskIDToList = new EventEmitter<string>();

  markAsDone(task: Task) {
    this.originalData.find(t => t.id === task.id)!.isDone = true;
    task.isDone = true;
  }

  updateTask(task: Task) {
    this.SendUpdatedTaskIDToList.emit(task.id);
  }

  markAsNotDone(task: Task) {
    this.originalData.find(t => t.id === task.id)!.isDone = false;
    task.isDone = false;
    this.data = this.data.filter(task => task.isDone);
  }

  deleteTask(task: Task) {
    const index = this.data.indexOf(task);
    if (index > -1)
    {
      this.data.splice(index, 1);
    }
    const originalIndex = this.originalData.findIndex(t => t.id === task.id);
    if (originalIndex > -1)
    {
      this.originalData.splice(originalIndex, 1);
    }
  }
}
