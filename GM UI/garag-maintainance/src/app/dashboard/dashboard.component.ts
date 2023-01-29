import { MessageHandlerService } from './../message-handler.service';
import { Component } from '@angular/core';


export interface Vehicle {
  make: string;
  model: string;
  color: string;
  licensePlate: string;
}

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css'],

})
export class DashboardComponent {


  vehicleMake: string = '';
  vehicleModel: string = '';
  vehicleColor: string = '';
  vehicleLicensePlate: string = '';

  public showForm: boolean = false;

  constructor(private Message: MessageHandlerService) { }


  successMessage() {
    this.Message.success("Hello");
  }
  addVehicle() {

  }
  public openForm() {
    this.showForm = true;
  }
  public closeForm() {
    this.showForm = false;
  }

}
