import { Routes } from '@angular/router';
import { App } from './app';
import { MySlider } from '../components/my-slider/my-slider';
import { MyTaskForm } from '../components/my-task-form/my-task-form';
import { MyTaskList } from '../components/my-task-list/my-task-list';
import { MyHome } from '../components/my-home/my-home';

export const routes: Routes =
[
  {
    title: 'Task Manager | Home',
    path: '',
    component: MyHome,
  },
  {
    title: 'Task Manager | Home',
    path: 'home',
    component: MyHome,
  },
  {
    title: 'Task Manager | Slider',
    path: 'slider',
    component: MySlider,
  },
  {
    title: 'Task Manager | Form',
    path: 'form',
    component: MyTaskForm,
  },
  {
    title: 'Task Manager | List',
    path: 'list',
    component: MyTaskList,
  },

];
