import { MessageHandlerService } from './../message-handler.service';
import { Component, TemplateRef, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';


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
  openForm() {
    throw new Error('Method not implemented.');
  }
  @ViewChild('dialogTemplate', { static: false })
  dialogTemplate!: TemplateRef<any>;

  vehicleMake: string = '';
  vehicleModel: string = '';
  vehicleColor: string = '';
  vehicleLicensePlate: string = '';

  public showForm: boolean = false;

  constructor(private Message: MessageHandlerService, private dialog: MatDialog) { }


  successMessage() {
    this.Message.success("Hello");
  }
  addVehicle() {

  }
  openDialog() {
    this.dialog.open(this.dialogTemplate);
  }

  closeDialog() {
    this.dialog.closeAll();
  }


}
