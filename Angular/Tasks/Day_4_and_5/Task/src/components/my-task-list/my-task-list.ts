import { Component, EventEmitter, inject, Output, signal } from '@angular/core';
import { MyTabs } from "../my-tabs/my-tabs";
import { MyAllTasks } from "../my-all-tasks/my-all-tasks";
import { TabChoice, Task, TaskAction } from '../../types';
import { MyDoneTasks } from "../my-done-tasks/my-done-tasks";
import { MyNotDoneTasks } from "../my-not-done-tasks/my-not-done-tasks";
import { APIService } from '../../app/services/apiservice';

@Component({
  selector: 'app-my-task-list',
  imports: [MyTabs, MyAllTasks, MyDoneTasks, MyNotDoneTasks],
  templateUrl: './my-task-list.html',
  styleUrl: './my-task-list.css',
})
export class MyTaskList {
  apiService = inject(APIService);
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
  @Output() SendTaskActionObjToApp = new EventEmitter<TaskAction>();
  ReceiveTaskActionObjFromFilteredList(TaskActionObj: TaskAction) {
    switch (TaskActionObj.action) {
      case 'delete':
        this.apiService.deleteTask(TaskActionObj.taskId).subscribe(() => {
          this.Tasks.set(this.Tasks().filter(task => task.id !== TaskActionObj.taskId));
        });
        break;
      case 'done':
        TaskActionObj.taskObj.isDone = true;
        this.apiService.updateTask(TaskActionObj.taskObj).subscribe((updatedTask) => {
          this.Tasks.set(this.Tasks().map(task => task.id === TaskActionObj.taskId ? updatedTask : task));
        });
        break;
      case 'not_done':
        TaskActionObj.taskObj.isDone = false;
        this.apiService.updateTask(TaskActionObj.taskObj).subscribe((updatedTask) => {
          this.Tasks.set(this.Tasks().map(task => task.id === TaskActionObj.taskId ? updatedTask : task));
        });
        break;
    }

    this.applyFilter();
  }

}
