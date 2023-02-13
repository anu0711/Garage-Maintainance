import { ApiHandlerService } from 'src/app/api-handler.service';
import { MessageHandlerService } from './../message-handler.service';
import { Component, TemplateRef, ViewChild, OnInit } from '@angular/core';
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
export class DashboardComponent implements OnInit {
  openForm() {
    throw new Error('Method not implemented.');
  }
  @ViewChild('dialogTemplate', { static: false })
  dialogTemplate!: TemplateRef<any>;

  vehicleMake: string = '';
  vehicleModel: string = '';
  vehicleColor: string = '';
  vehicleLicensePlate: string = '';
  dashBoardData: any[] = [];
  isLoading: boolean = false;

  public showForm: boolean = false;

  constructor(private Message: MessageHandlerService, private dialog: MatDialog, private ApiClient: ApiHandlerService) { }

  ngOnInit(): void {
    this.isLoading = true;
    this.ApiClient.GetDashBoardDetails().subscribe((data: any) => {
      this.dashBoardData = data;
      debugger;
      this.isLoading = false;
    })
  }

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
