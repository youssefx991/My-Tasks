import { Component, EventEmitter, Input, Output } from '@angular/core';
import { MyTabs } from "../my-tabs/my-tabs";
import { MyAllTasks } from "../my-all-tasks/my-all-tasks";
import { Task } from '../../types';
import { MyDoneTasks } from "../my-done-tasks/my-done-tasks";
import { MyNotDoneTasks } from "../my-not-done-tasks/my-not-done-tasks";

@Component({
  selector: 'app-my-task-list',
  imports: [MyTabs, MyAllTasks, MyDoneTasks, MyNotDoneTasks],
  templateUrl: './my-task-list.html',
  styleUrl: './my-task-list.css',
})
export class MyTaskList {
  @Input() TasksFromProject: Task[] = [];
  choice: string = "all";
  onTabChoice(tab: string) {
    this.choice = tab;
  }

  @Output() SendUpdatedTaskIDToProject = new EventEmitter<{ taskId: string; uuid: string }>();
  ReceiveUpdatedTaskID(updateObj: { taskId: string; uuid: string }) {
    console.log("update flag from Task List: ", updateObj);
    this.SendUpdatedTaskIDToProject.emit(updateObj);
  }

}
