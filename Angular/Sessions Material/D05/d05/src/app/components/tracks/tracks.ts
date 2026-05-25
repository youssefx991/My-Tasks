import { Component } from '@angular/core';
import { RouterOutlet, RouterLinkWithHref } from '@angular/router';
import { Sidebar } from "../sidebar/sidebar";

@Component({
  selector: 'app-tracks',
  imports: [RouterOutlet, RouterLinkWithHref, Sidebar],
  templateUrl: './tracks.html',
  styles: ``,
})
export class Tracks {}
