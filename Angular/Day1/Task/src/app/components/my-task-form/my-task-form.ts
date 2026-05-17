import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-my-task-form',
  imports: [FormsModule],
  templateUrl: './my-task-form.html',
  styleUrl: './my-task-form.css',
})
export class MyTaskForm {
  TaskTitle: string = 'N/A';
  TaskDescription: string = 'N/A';
  TaskPriority: Priority = Priority.Low;
  TaskDueDate: Date = new Date();
  TaskCategory: Category = Category.Work;
  TaskTags: string = 'N/A';
  TaskTagsArray: string[] = [];
  Tasks: Task[] = [];



  addTask() {

    if (this.TaskTags)
      this.TaskTagsArray = this.TaskTags.split(' ').map(tag => tag.trim());
    this.Tasks.push(new Task(this.TaskTitle, this.TaskDescription, this.TaskPriority, this.TaskDueDate, this.TaskCategory, this.TaskTagsArray));
    console.log(this.Tasks);

  }
}

class Task {
  title: string;
  description: string;
  priority: Priority;
  dueDate: Date;
  category: Category;
  tags: string[];

  constructor(title: string, description: string, priority: Priority, dueDate: Date, category: Category, tags: string[]) {
    this.title = title;
    this.description = description;
    this.priority = priority;
    this.dueDate = dueDate;
    this.category = category;
    this.tags = tags;
  }
}

enum Priority {
  Low = 'low',
  Medium = 'medium',
  High = 'high',
}

enum Category {
  Work = 'work',
  Personal = 'personal',
  Study = 'study',
}
