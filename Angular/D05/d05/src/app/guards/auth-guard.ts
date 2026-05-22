import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';

export const authGuard: CanActivateFn = (route, state) => {
  let check = false;
  const router = inject(Router);

  if (check) {
    return true;
  }

  router.navigate(['/login']);
  return false;
};
