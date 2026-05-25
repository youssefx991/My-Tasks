import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Task } from '../../types';

@Component({
  selector: 'app-my-task-form',
  imports: [FormsModule],
  templateUrl: './my-task-form.html',
  styleUrl: './my-task-form.css',
})
export class MyTaskForm {
  private _formTaskIDObj: { taskId: string; uuid: string } = { taskId: '', uuid: '' };
  @Input() TasksFromProject: Task[] = [];


  FormTags : string = '';
  FormTask : Task = new Task();
  @Output() SendTaskToProject = new EventEmitter<Task>();

  @Input()
  set FormTaskIDObj(value: { taskId: string; uuid: string }) {
    this._formTaskIDObj = value;
    if (value.taskId === '') {
      this.resetForm();
      return;
    }

    const task = this.TasksFromProject.find(task => task.id === value.taskId);
    if (task) {
      this.FormTask = { ...task };
      this.FormTags = this.FormTask.tags ? this.FormTask.tags.join(' ') : '';
    }
  }

  get FormTaskIDObj(): { taskId: string; uuid: string } {
    return this._formTaskIDObj;
  }

  addTask() {
    if (this.FormTask.tags)
      this.FormTask.tags = this.FormTags.split(' ').map(tag => tag.trim());

    const newTask = new Task(
      this.FormTask.title,
      this.FormTask.description,
      this.FormTask.priority,
      this.FormTask.dueDate,
      this.FormTask.category,
      this.FormTask.tags,
      this.FormTask.isDone
    );

    if (this.FormTaskIDObj.taskId === '') {
      this.SendTaskToProject.emit(newTask);
    } else {
      console.log("updating task: ", newTask);
      const task = this.TasksFromProject.find(task => task.id === this.FormTaskIDObj.taskId);
      if (task) {
        task.title = newTask.title;
        task.description = newTask.description;
        task.priority = newTask.priority;
        task.dueDate = newTask.dueDate;
        task.category = newTask.category;
        task.tags = newTask.tags;
        task.isDone = newTask.isDone;
      }

      this.resetForm();
    }
  }

  resetForm() {
    this.FormTask = new Task();
    this.FormTags = '';
    this._formTaskIDObj = { taskId: '', uuid: '' };
  }
}



