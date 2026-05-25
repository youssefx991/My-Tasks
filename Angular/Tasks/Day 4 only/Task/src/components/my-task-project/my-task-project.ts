import { Component } from '@angular/core';
import { MyTaskForm } from '../my-task-form/my-task-form';
import { MyTaskList } from '../my-task-list/my-task-list';
import { Task, TaskAction, TaskActionType} from '../../types';

@Component({
  selector: 'app-my-task-project',
  imports: [MyTaskForm, MyTaskList],
  templateUrl: './my-task-project.html',
  styleUrl: './my-task-project.css',
})
export class MyTaskProject {
  AllTasks: Task[] = [
    new Task('Task 1', 'Description for Task 1'),
    new Task('Task 2', 'Description for Task 2'),
    new Task('Task 3', 'Description for Task 3'),
    new Task('Task 4', 'Description for Task 4'),
    new Task('Task 5', 'Description for Task 5'),
    new Task('Task 6', 'Description for Task 6'),
    new Task('Task 7', 'Description for Task 7'),
    new Task('Task 8', 'Description for Task 8'),
    new Task('Task 9', 'Description for Task 9'),
    new Task('Task 10', 'Description for Task 10'),
    new Task('Task 11', 'Description for Task 11'),
    new Task('Task 12', 'Description for Task 12'),
    new Task('Task 13', 'Description for Task 13'),
    new Task('Task 14', 'Description for Task 14'),
    new Task('Task 15', 'Description for Task 15'),
    new Task('Task 16', 'Description for Task 16'),
    new Task('Task 17', 'Description for Task 17'),
    new Task('Task 18', 'Description for Task 18'),
    new Task('Task 19', 'Description for Task 19'),
    new Task('Task 20', 'Description for Task 20'),
  ];


  DoneTasks: Task[] = [];
  UndoneTasks: Task[] = [];

  TaskActionObj : TaskAction = new TaskAction();

  ReceiveTaskActionObjFromForm(TaskActionObj: TaskAction) {
    if (TaskActionObj.action === TaskActionType.ADD) {
      this.AllTasks = [...this.AllTasks, TaskActionObj.taskObj];
    } else if (TaskActionObj.action === TaskActionType.UPDATE) {
      this.AllTasks = this.AllTasks.map(task =>
        task.id === TaskActionObj.taskId ? TaskActionObj.taskObj : task
      );
    }

    this.TaskActionObj = new TaskAction();
  }

  ReceiveTaskActionObjFromList(TaskActionObj: TaskAction) {
    this.TaskActionObj = { ...TaskActionObj };
    if (TaskActionObj.action === TaskActionType.DELETE) {
      this.AllTasks = this.AllTasks.filter(task => task.id !== TaskActionObj.taskId);
    } else if (TaskActionObj.action === TaskActionType.DONE) {
      this.AllTasks = this.AllTasks.map(task =>
        task.id === TaskActionObj.taskId ? { ...task, isDone: true } : task
      );
    } else if (TaskActionObj.action === TaskActionType.NOT_DONE) {
      this.AllTasks = this.AllTasks.map(task =>
        task.id === TaskActionObj.taskId ? { ...task, isDone: false } : task
      );
    }
  }
}

