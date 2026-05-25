import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { App } from './app/app';

// bootstrap function
// start our application
// needs only one component => App
// takes that component start application with component => Html , CSS , TS
// locate -> where this component will be displayed
// first component will be created in application
// root component  (App) -> will carry all application's components
bootstrapApplication(App, appConfig).catch((err) => console.error(err));
