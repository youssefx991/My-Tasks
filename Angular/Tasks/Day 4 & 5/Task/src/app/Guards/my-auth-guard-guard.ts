import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';

// should only allow access to the route if the user is authenticated in local storage
export const myAuthGuardGuard: CanActivateFn = (route, state) => {
  let router = inject(Router);
  let authorized =localStorage.getItem('isLoggedIn') === 'true';
  if (!authorized) {
    router.navigate(['/notfound']);}

  return true;
};
