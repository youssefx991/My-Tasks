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
  Tasks: Task[] = [
    new Task('Task 1', 'Description for Task 1'),
    new Task('Task 2', 'Description for Task 2'),
    new Task('Task 3', 'Description for Task 3'),
    new Task('Task 4', 'Description for Task 4'),
    new Task('Task 5', 'Description for Task 5'),
    new Task('Task 6', 'Description for Task 6'),
    new Task('Task 7', 'Description for Task 7'),
    new Task('Task 8', 'Description for Task 8'),
    new Task('Task 9', 'Description for Task 9'),
    new Task('Task 10', 'Description for Task 10'),
    new Task('Task 11', 'Description for Task 11'),
    new Task('Task 12', 'Description for Task 12'),
    new Task('Task 13', 'Description for Task 13'),
    new Task('Task 14', 'Description for Task 14'),
    new Task('Task 15', 'Description for Task 15'),
    new Task('Task 16', 'Description for Task 16'),
    new Task('Task 17', 'Description for Task 17'),
    new Task('Task 18', 'Description for Task 18'),
    new Task('Task 19', 'Description for Task 19'),
    new Task('Task 20', 'Description for Task 20'),
  ];
  DisplayedTasks: Task[] = [...this.Tasks];
  TabChoice = TabChoice;

  choice: TabChoice = TabChoice.ALL;
  onTabChoice(tab: TabChoice) {
    this.choice = tab;
    this.applyFilter();
  }

  applyFilter() {
    switch (this.choice) {
      case TabChoice.ALL:
        this.DisplayedTasks = [...this.Tasks];
        break;
      case TabChoice.DONE:
        this.DisplayedTasks = [...this.Tasks.filter(task => task.isDone)];
        break;
      case TabChoice.NOT_DONE:
        this.DisplayedTasks = [...this.Tasks.filter(task => !task.isDone)];
        break;
    }
  }
  ngOnChanges(changes: SimpleChanges) {
    console.log("Tasks in List onChanges: ", this.Tasks);
    console.log("Tasks in List onChanges: ", changes['Tasks']?.firstChange);
    if (changes['Tasks']) {
      this.applyFilter();
    }

  }

  @Output() SendTaskActionObjToApp = new EventEmitter<TaskAction>();
  ReceiveTaskActionObjFromFilteredList(TaskActionObj: TaskAction) {
    // this.SendTaskActionObjToApp.emit(TaskActionObj);
    switch (TaskActionObj.action) {
      case 'delete':
        this.Tasks = this.Tasks.filter(task => task.id !== TaskActionObj.taskId);
        this.DisplayedTasks = this.DisplayedTasks.filter(task => task.id !== TaskActionObj.taskId);
        break;
      case 'done':
        this.Tasks = this.Tasks.map(task =>
          task.id === TaskActionObj.taskId ? { ...task, isDone: true } : task
        );
        this.DisplayedTasks = this.DisplayedTasks.map(task =>
          task.id === TaskActionObj.taskId ? { ...task, isDone: true } : task
        );
        break;
      case 'not_done':
        this.Tasks = this.Tasks.map(task =>
          task.id === TaskActionObj.taskId ? { ...task, isDone: false } : task
        );
        this.DisplayedTasks = this.DisplayedTasks.map(task =>
          task.id === TaskActionObj.taskId ? { ...task, isDone: false } : task
        );
        break;
    }
  }

}
