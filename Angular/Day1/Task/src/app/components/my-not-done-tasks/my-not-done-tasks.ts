import { Component, EventEmitter, Input, Output } from '@angular/core';
import { v4 as uuidv4 } from 'uuid';
import { Task } from '../../types';

@Component({
  selector: 'app-my-not-done-tasks',
  imports: [],
  templateUrl: './my-not-done-tasks.html',
  styleUrl: './my-not-done-tasks.css',
})
export class MyNotDoneTasks {
  @Input() TasksFromList: Task[] = [];

  get data(): Task[] {
    return this.TasksFromList.filter(task => !task.isDone);
  }

  @Output() SendUpdatedTaskIDToList = new EventEmitter<{ taskId: string; uuid: string }>();

  markAsDone(task: Task) {
    task.isDone = true;
  }

  updateTask(task: Task) {
    this.SendUpdatedTaskIDToList.emit({ taskId: task.id, uuid: uuidv4() });
  }

  markAsNotDone(task: Task) {
    task.isDone = false;
  }

  deleteTask(task: Task) {
    const index = this.TasksFromList.findIndex(t => t.id === task.id);
    if (index > -1)
      this.TasksFromList.splice(index, 1);
  }
}
