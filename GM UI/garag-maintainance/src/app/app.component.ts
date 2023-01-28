import { BooleanInput } from '@angular/cdk/coercion';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  opened: BooleanInput = false;
  shouldRun: any = true;
  events: any = []
  isLogin = window.location.pathname == "/register" || window.location.pathname == "/login";

}
