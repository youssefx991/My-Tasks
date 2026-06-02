import { Component, inject, OnInit, signal } from '@angular/core';
import { MyTabs } from "../my-tabs/my-tabs";
import { MyAllTasks } from "../my-all-tasks/my-all-tasks";
import { TabChoice, Task, TaskAction, TaskActionType } from '../../types';
import { MyDoneTasks } from "../my-done-tasks/my-done-tasks";
import { MyNotDoneTasks } from "../my-not-done-tasks/my-not-done-tasks";
import { APIService } from '../../app/services/apiservice';
import { Router } from '@angular/router';

@Component({
  selector: 'app-my-task-list',
  imports: [MyTabs, MyAllTasks, MyDoneTasks, MyNotDoneTasks],
  templateUrl: './my-task-list.html',
  styleUrl: './my-task-list.css',
})
export class MyTaskList implements OnInit {
  apiService = inject(APIService);
  router = inject(Router);
  Tasks = signal<Task[]>([]);

  DisplayedTasks: Task[] = [...this.Tasks()];
  TabChoice = TabChoice;

  choice: TabChoice = TabChoice.ALL;

  ngOnInit() {
    this.apiService.getTasks().subscribe((tasks: Task[]) => {
      this.Tasks.set(tasks);
      this.applyFilter();

    });
  }
  onTabChoice(tab: TabChoice) {
    this.choice = tab;
    this.applyFilter();
  }

  applyFilter() {
    switch (this.choice) {
      case TabChoice.ALL:
        this.DisplayedTasks = [...this.Tasks()];
        break;
      case TabChoice.DONE:
        this.DisplayedTasks = [...this.Tasks().filter(task => task.isDone)];
        break;
      case TabChoice.NOT_DONE:
        this.DisplayedTasks = [...this.Tasks().filter(task => !task.isDone)];
        break;
    }
  }
  ReceiveTaskActionObjFromFilteredList(TaskActionObj: TaskAction) {
    switch (TaskActionObj.action) {
      case TaskActionType.DELETE:
        this.apiService.deleteTask(TaskActionObj.taskId).subscribe(() => {
          this.Tasks.set(this.Tasks().filter(task => task.id !== TaskActionObj.taskId));
          this.applyFilter();
        });
        break;
      case TaskActionType.DONE: {
        const updatedTaskObj = { ...TaskActionObj.taskObj, isDone: true };
        this.apiService.updateTask(updatedTaskObj).subscribe((updatedTask) => {
          this.Tasks.set(this.Tasks().map(task => task.id === TaskActionObj.taskId ? updatedTask : task));
          this.applyFilter();
        });
        break;
      }
      case TaskActionType.NOT_DONE: {
        const updatedTaskObj = { ...TaskActionObj.taskObj, isDone: false };
        this.apiService.updateTask(updatedTaskObj).subscribe((updatedTask) => {
          this.Tasks.set(this.Tasks().map(task => task.id === TaskActionObj.taskId ? updatedTask : task));
          this.applyFilter();
        });
        break;
      }
      case TaskActionType.UPDATE:
        this.apiService.setTaskToEdit(TaskActionObj.taskObj);
        this.router.navigate(['/form']);
        break;
    }
  }

}
