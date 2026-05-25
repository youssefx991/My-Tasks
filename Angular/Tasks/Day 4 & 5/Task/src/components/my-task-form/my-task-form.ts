import { Component, EventEmitter, input, Input, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { error, Task, TaskAction, TaskActionType } from '../../types';

@Component({
  selector: 'app-my-task-form',
  imports: [FormsModule],
  templateUrl: './my-task-form.html',
  styleUrl: './my-task-form.css',
})
export class MyTaskForm {
  @Input() TaskActionObjFromApp: TaskAction = new TaskAction();

  FormTags: string = '';
  FormTask: Task = new Task();
  action: TaskActionType = TaskActionType.ADD;
  error: error = { message: '', state: false };

  ngOnChanges() {
    console.log("TaskActionObjFromApp in form ngOnChanges: ", this.TaskActionObjFromApp);
    if (this.TaskActionObjFromApp.action === TaskActionType.UPDATE) {
      this.FormTask = { ...this.TaskActionObjFromApp.taskObj };
      this.FormTags = this.FormTask.tags ? this.FormTask.tags.join(' ') : '';
      this.action = TaskActionType.UPDATE;
    } else if (this.TaskActionObjFromApp.action === TaskActionType.ADD) {
      this.resetForm();
      this.action = TaskActionType.ADD;
    }
  }

  @Output() SendTaskActionObjToApp = new EventEmitter<TaskAction>();


  addTask() {
    console.log("FormTask before validation: ", this.FormTask);
    if (this.FormTask.tags)
      this.FormTask.tags = this.FormTags.split(' ').map(tag => tag.trim());

    if (this.FormTags === '') {
      this.error = { message: 'Please fill all the fields', state: true };
      return;
    }
    const newTask = new Task(
      this.FormTask.title,
      this.FormTask.description,
      this.FormTask.priority,
      this.FormTask.dueDate,
      this.FormTask.category,
      this.FormTask.tags,
      this.FormTask.isDone
    );

    for (const key of Object.keys(newTask) as (keyof Task)[]) {
      if (newTask[key] === '' || newTask[key] === null || newTask[key] === undefined) {
        this.error = { message: 'Please fill all the fields', state: true };
        return;
      }
    }
    if (this.action === TaskActionType.ADD) {
      console.log("adding task in form: ", newTask);
      this.SendTaskActionObjToApp.emit(new TaskAction(newTask.id, newTask, TaskActionType.ADD));
    } else {
      console.log("updating task in form: ", newTask);
      this.SendTaskActionObjToApp.emit(new TaskAction(this.FormTask.id, newTask, TaskActionType.UPDATE));

      this.resetForm();
    }
  }

  resetForm() {
    this.FormTask = new Task();
    this.FormTags = '';
    this.action = TaskActionType.ADD;
    this.error = { message: '', state: false };
  }
}



