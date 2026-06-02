import { Component, EventEmitter, Input, Output, SimpleChanges } from '@angular/core';
import { v4 as uuidv4 } from 'uuid';
import { Task, TaskAction, TaskActionType } from '../../types';


@Component({
  selector: 'app-my-not-done-tasks',
  imports: [],
  templateUrl: './my-not-done-tasks.html',
  styleUrl: './my-not-done-tasks.css',
})
export class MyNotDoneTasks {
  @Input() TasksFromList: Task[] = [];

  // get data(): Task[] {
  //   return this.TasksFromList.filter(task => !task.isDone);
  // }

  @Output() SendTaskActionObjToList = new EventEmitter<TaskAction>();
  ngOnChanges(changes: SimpleChanges) {
    console.log("Tasks in Not Done Tasks onChanges: ", this.TasksFromList);
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
