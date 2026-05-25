import { Component, EventEmitter, Input, Output } from '@angular/core';
import { MyTaskForm } from "../my-task-form/my-task-form";
import { MyTaskList } from "../my-task-list/my-task-list";
import { Task } from '../../types';

@Component({
  selector: 'app-my-task-project',
  imports: [MyTaskForm, MyTaskList],
  templateUrl: './my-task-project.html',
  styleUrl: './my-task-project.css',
})
export class MyTaskProject {
  ProjectTask! : Task;
  @Input() TasksFromApp: Task[] = [];
  @Output() SendTaskToApp = new EventEmitter<Task>();
  FormTaskIDObj: { taskId: string; uuid: string } = { taskId: '', uuid: '' };
  ReceiveTaskFromForm(TaskFromForm: Task) {
    this.ProjectTask = TaskFromForm;
    this.SendTaskToApp.emit(this.ProjectTask);
  }

  ReceiveUpdatedTaskIDFromList(updateObj: { taskId: string; uuid: string }) {
    // console.log("update flag from project: ", updateObj);
    this.FormTaskIDObj = updateObj;
  }
}
