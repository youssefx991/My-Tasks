import { v4 as uuidv4 } from 'uuid';

export class Task {
  id : string;
  title: string;
  description: string;
  priority: Priority;
  dueDate: Date;
  category: Category;
  tags: string[];
  isDone: boolean;


  constructor(title: string = 'N/A', description: string = 'N/A', priority: Priority = Priority.Low, dueDate: Date = new Date(), category: Category = Category.Work, tags: string[] = ['N/A'], isDone: boolean = false) {
    this.id = uuidv4().split('-')[0];
    this.title = title;
    this.description = description;
    this.priority = priority;
    this.dueDate = dueDate;
    this.category = category;
    this.tags = tags;
    this.isDone = isDone;
  }
}

export enum Priority {
  Low = 'low',
  Medium = 'medium',
  High = 'high',
}

export enum Category {
  Work = 'work',
  Personal = 'personal',
  Study = 'study',
}



