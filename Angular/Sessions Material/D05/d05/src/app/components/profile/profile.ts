import { Location } from '@angular/common';
import { Component, inject } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-profile',
  imports: [],
  templateUrl: './profile.html',
  styles: ``,
})
export class Profile {
  // inject ActivatedRoute
  // constructor(private route: ActivatedRoute) {}
  route = inject(ActivatedRoute);
  id = '';
  ngOnInit() {
    console.log(this.route);
    let d = this.route.snapshot.params['id'];
    this.id = d;
  }

  get dis() {
    console.log('profile');
    return;
  }
  ngOnDestroy() {
    console.log('ngOnDestroy');
  }

  // d() {
  //   console.log('object');
  // }

  //programmatic routing -> inject Router
  router = inject(Router);
  home() {
    this.router.navigate(['/layout', 'home']);
  }
  location = inject(Location);
  d() {
    this.location.back();
  }
}

// canactive selfstudy -> guard -> ng g g auth -> protected routes
