import { Component, EventEmitter, input, Input, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Category, Priority, Task } from '../../types';

@Component({
  selector: 'app-my-task-form',
  imports: [FormsModule],
  templateUrl: './my-task-form.html',
  styleUrl: './my-task-form.css',
})
export class MyTaskForm {
  @Input() FormTaskID: string = '';
  @Input() TasksFromProject: Task[] = [];
  FormTags : string = '';
  FormTask : Task = this.FormTaskID === '' ? new Task() : this.TasksFromProject.find(task => task.id === this.FormTaskID) || new Task();
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

    if (this.FormTaskID !== '')
    {
      console.log("updating task: ", newTask);
      const task = this.TasksFromProject.find(task => task.id === this.FormTaskID);
      if (task) {
        task.title = newTask.title;
        task.description = newTask.description;
        task.priority = newTask.priority;
        task.dueDate = newTask.dueDate;
        task.category = newTask.category;
        task.tags = newTask.tags;
        task.isDone = newTask.isDone;
      }
      
      this.FormTaskID = '';
    }
    else
      this.SendTaskToProject.emit(newTask);

    // console.log(this.TasksFromProject);

  }
}


