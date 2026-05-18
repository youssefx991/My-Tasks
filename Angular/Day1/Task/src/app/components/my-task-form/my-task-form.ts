import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Category, Priority, Task } from '../../types';

@Component({
  selector: 'app-my-task-form',
  imports: [FormsModule],
  templateUrl: './my-task-form.html',
  styleUrl: './my-task-form.css',
})
export class MyTaskForm {
  FormTask : Task = new Task();
  FormTags : string = '';
  @Input() TasksFromProject: Task[] = [];
  @Output() SendTaskToProject = new EventEmitter<Task>();

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
    this.SendTaskToProject.emit(newTask);

    console.log(this.TasksFromProject);

  }
}


