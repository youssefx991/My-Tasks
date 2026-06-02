import { Component, EventEmitter, inject, Input, OnChanges, Output } from '@angular/core';
import { ReactiveFormsModule, FormGroup, Validators, FormControl } from '@angular/forms';
import { Category, error, Priority, Task, TaskAction, TaskActionType } from '../../types';
import { APIService } from '../../app/services/apiservice';

@Component({
  selector: 'app-my-task-form',
  imports: [ReactiveFormsModule],
  templateUrl: './my-task-form.html',
  styleUrl: './my-task-form.css',
})
export class MyTaskForm implements OnChanges {
  apiService = inject(APIService);

  taskForm = new FormGroup({
    title: new FormControl('', [Validators.required]),
    description: new FormControl('', [Validators.required]),
    priority: new FormControl('low', [Validators.required]),
    dueDate: new FormControl('', [Validators.required]),
    category: new FormControl('work', [Validators.required]),
    tags: new FormControl('', [Validators.required]),
    isDone: new FormControl(false)
  });

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
      this.taskForm.patchValue({
        title: this.FormTask.title,
        description: this.FormTask.description,
        priority: this.FormTask.priority,
        dueDate: this.FormTask.dueDate ? new Date(this.FormTask.dueDate).toISOString().slice(0, 10) : '',
        category: this.FormTask.category,
        tags: this.FormTags,
        isDone: this.FormTask.isDone,
      });
      this.action = TaskActionType.UPDATE;
    } else if (this.TaskActionObjFromApp.action === TaskActionType.ADD) {
      this.resetForm();
      this.action = TaskActionType.ADD;
    }
  }

  @Output() SendTaskActionObjToApp = new EventEmitter<TaskAction>();


  addTask() {
    if (this.taskForm.invalid) {
      this.error = { message: 'Please fill all the fields correctly', state: true };
      return;
    }

    const formValue = this.taskForm.getRawValue();

    const newTask = new Task(
      formValue.title ?? '',
      formValue.description ?? '',
      formValue.priority as Priority,
      formValue.dueDate ? new Date(formValue.dueDate) : new Date(),
      formValue.category as Category,
      typeof formValue.tags === 'string' ? formValue.tags.trim().split(/\s+/).filter(Boolean) : [],
      formValue.isDone ?? false
    );

    if (this.action === TaskActionType.UPDATE) {
      newTask.id = this.FormTask.id;
    }



    if (this.action === TaskActionType.ADD) {
      this.apiService.addTask(newTask).subscribe((addedTask: Task) => {
        this.SendTaskActionObjToApp.emit(new TaskAction(addedTask.id, addedTask, TaskActionType.ADD));
        console.log("Added Task in form: ", addedTask);
        this.resetForm();
      });
    } else {
      this.apiService.updateTask(newTask).subscribe((updatedTask: Task) => {
        this.SendTaskActionObjToApp.emit(new TaskAction(updatedTask.id, updatedTask, TaskActionType.UPDATE));
        console.log("Updated Task in form: ", updatedTask);
        this.resetForm();
      });
    }
  }

  resetForm() {
    this.FormTask = new Task();
    this.taskForm.reset({
      title: '',
      description: '',
      priority: 'low',
      dueDate: '',
      category: 'work',
      tags: '',
      isDone: false,
    });
    this.FormTags = '';
    this.action = TaskActionType.ADD;
    this.error = { message: '', state: false };
  }
}



