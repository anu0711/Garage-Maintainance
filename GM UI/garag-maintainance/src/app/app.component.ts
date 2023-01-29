import { BooleanInput } from '@angular/cdk/coercion';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  logout() {
    throw new Error('Method not implemented.');
  }
  opened: BooleanInput = false;
  shouldRun: any = true;
  events: any = [];
  window = window;

}
