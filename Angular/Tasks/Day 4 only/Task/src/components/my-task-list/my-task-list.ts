import { Component, EventEmitter, Input, Output, SimpleChanges, OnChanges } from '@angular/core';
import { MyTabs } from "../my-tabs/my-tabs";
import { MyAllTasks } from "../my-all-tasks/my-all-tasks";
import { TabChoice, Task, TaskAction } from '../../types';
import { MyDoneTasks } from "../my-done-tasks/my-done-tasks";
import { MyNotDoneTasks } from "../my-not-done-tasks/my-not-done-tasks";

@Component({
  selector: 'app-my-task-list',
  imports: [MyTabs, MyAllTasks, MyDoneTasks, MyNotDoneTasks],
  templateUrl: './my-task-list.html',
  styleUrl: './my-task-list.css',
})
export class MyTaskList {
  @Input() TasksFromApp: Task[] = [];
  DisplayedTasks: Task[] = [];
  TabChoice = TabChoice;

  choice: TabChoice = TabChoice.ALL;
  onTabChoice(tab: TabChoice) {
    this.choice = tab;
    this.applyFilter();
  }

  applyFilter() {
    switch (this.choice) {
      case TabChoice.ALL:
        this.DisplayedTasks = [...this.TasksFromApp];
        break;
      case TabChoice.DONE:
        this.DisplayedTasks = [...this.TasksFromApp.filter(task => task.isDone)];
        break;
      case TabChoice.NOT_DONE:
        this.DisplayedTasks = [...this.TasksFromApp.filter(task => !task.isDone)];
        break;
    }
  }

  ngOnChanges(changes: SimpleChanges) {
    console.log("Tasks in List onChanges: ", this.TasksFromApp);
    console.log("Tasks in List onChanges: ", changes['TasksFromApp']?.firstChange);
    if (changes['TasksFromApp']) {
      this.applyFilter();
    }

  }

  @Output() SendTaskActionObjToApp = new EventEmitter<TaskAction>();
  ReceiveTaskActionObjFromFilteredList(TaskActionObj: TaskAction) {
    this.SendTaskActionObjToApp.emit(TaskActionObj);
    this.applyFilter();
  }

}
