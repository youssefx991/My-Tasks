import { Component, EventEmitter, Input, Output, SimpleChanges } from '@angular/core';
import { v4 as uuidv4 } from 'uuid';
import { Task, TaskAction, TaskActionType } from '../../types';

@Component({
  selector: 'app-my-all-tasks',
  imports: [],
  templateUrl: './my-all-tasks.html',
})
export class MyAllTasks {
  @Input() TasksFromList : Task[] = [];
  @Output() SendTaskActionObjToList = new EventEmitter<TaskAction>();

  ngOnChanges(changes: SimpleChanges) {
    console.log("Tasks in All Tasks onChanges: ", this.TasksFromList);
    if (!changes['TasksFromList']?.firstChange) {
      this.TasksFromList = [...this.TasksFromList];
    }
  }
  markAsDone(task: Task) {
    this.SendTaskActionObjToList.emit(new TaskAction(task.id, task, TaskActionType.DONE));
  }

  updateTask(task: Task) {
    this.SendTaskActionObjToList.emit(new TaskAction(task.id, task, TaskActionType.UPDATE));
  }

  markAsNotDone(task: Task) {
    this.SendTaskActionObjToList.emit(new TaskAction(task.id, task, TaskActionType.NOT_DONE));
  }

  deleteTask(task: Task) {
    this.SendTaskActionObjToList.emit(new TaskAction(task.id, task, TaskActionType.DELETE));
  }
}
