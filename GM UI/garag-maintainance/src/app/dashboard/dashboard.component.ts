import { MessageHandlerService } from './../message-handler.service';
import { Component } from '@angular/core';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css'],

})
export class DashboardComponent {

  constructor(private Message: MessageHandlerService) { }


  successMessage() {
    this.Message.success("vakannakda Maple");
  }

}
