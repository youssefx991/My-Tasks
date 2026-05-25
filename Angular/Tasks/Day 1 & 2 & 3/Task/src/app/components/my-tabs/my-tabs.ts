import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-my-tabs',
  imports: [],
  templateUrl: './my-tabs.html',
  styleUrl: './my-tabs.css',
})
export class MyTabs {
  @Output() SendTabChoiceToList = new EventEmitter<string>();

  SwitchTab(tab: string) {
    this.SendTabChoiceToList.emit(tab);
  }
}
