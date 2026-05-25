import { Routes } from '@angular/router';
import { Home } from './components/home/home';
import { About } from './components/about/about';
import { Users } from './components/users/users';
import { Tracks } from './components/tracks/tracks';
import { Login } from './components/login/login';
import { Signup } from './components/signup/signup';
import { Notfound } from './components/notfound/notfound';
import { Web } from './components/web/web';
import { Mobile } from './components/mobile/mobile';
import { Layout } from './components/layout/layout';
import { Profile } from './components/profile/profile';
import { authGuard } from './guards/auth-guard';

export const routes: Routes = [
  //   {
  //     path: '',
  //     component: Layout,
  //     children: [
  //       {
  //         title: 'ITI',
  //         path: '',
  //         component: Home,
  //       },
  //       {
  //         title: 'ITI | Home',
  //         path: 'home',
  //         component: Home,
  //       },
  //       {
  //         title: 'ITI | About',
  //         path: 'about',
  //         component: About,
  //       },
  //       {
  //         title: 'ITI | Users',
  //         path: 'users',
  //         component: Users,
  //       },
  //       {
  //         title: 'ITI | Tracks',
  //         path: 'tracks',
  //         component: Tracks,
  //         // ""/tracks
  //         children: [
  //           {
  //             title: 'ITI | Tracks',
  //             path: '',
  //             component: Web,
  //           },
  //           {
  //             title: 'ITI | Tracks | Web',
  //             path: 'web',
  //             component: Web,
  //           },
  //           {
  //             title: 'ITI | Tracks | Mobile',
  //             path: 'mobile',
  //             component: Mobile,
  //           },
  //           {
  //             path: '**',
  //             component: Notfound,
  //           },
  //         ], // route[]
  //       },
  //     ],
  //   },

  {
    path: '',
    // redirection
    redirectTo: 'layout',
    // pathMatch: 'prefix',
    pathMatch: 'full',
  },
  {
    path: 'layout',
    component: Layout,
    // nested route -> children
    children: [
      {
        title: 'ITI',
        path: '',
        component: Home,
      },
      {
        title: 'ITI | Home',
        path: 'home',
        component: Home,
      },
      {
        title: 'ITI | About',
        path: 'about',
        component: About,
      },
      {
        title: 'ITI | Users',
        path: 'users',
        canActivate: [authGuard],
        component: Users,
      },
      {
        path: 'profile/:id', // route param  -> id = 1
        component: Profile,
      },
      {
        title: 'ITI | Tracks',
        path: 'tracks',
        component: Tracks,
        // /layout/tracks/
        // nested routes (sup pages) -> /tracks/web
        children: [
          {
            title: 'ITI | Tracks',
            path: '',
            component: Web,
          },
          {
            title: 'ITI | Tracks | Web',
            path: 'web',
            component: Web,
          },
          {
            title: 'ITI | Tracks | Mobile',
            path: 'mobile',
            component: Mobile,
          },
          {
            path: '**',
            component: Notfound,
          },
        ], // route[]
      },
    ],
  },
  {
    title: 'ITI | Login',
    path: 'login',
    component: Login,
  },
  {
    title: 'ITI | Signup',
    path: 'signup',
    component: Signup,
  },
  {
    path: '**', // wildcard -> match any path // true
    component: Notfound,
  },
  //   {
  //     path: 'notfound',
  //     component: Notfound,
  //   },
]; // Route[]

// create layouts => component (page)   => Header & router-outlet (home , about , tracks)
