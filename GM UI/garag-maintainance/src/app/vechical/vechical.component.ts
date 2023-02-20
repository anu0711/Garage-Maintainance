import { ApiHandlerService } from './../api-handler.service';
import { SelectionModel } from '@angular/cdk/collections';
import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { AddOrUpdataVehicleComponent } from './add-or-updata-vehicle/add-or-updata-vehicle.component';

export interface VehicleModel {
  id: any,
  createdDate: Date,
  updatedDate: Date,
  isActive: boolean,
  createdBy: any,
  updatedBy: any,
  vehicleName: string,
  vehicleType: string,
  rcActive: boolean,
  vehicleNumber: string,
  insuranceValidity: Date,
  fitnessValidity: Date
}
/**
 * @title Table with selection
 */
@Component({
  selector: 'app-vechical',
  templateUrl: 'vechical.component.html',
  styles: []
})
export class VechicalComponent implements OnInit {
  displayedColumns: string[] = ['select', 'vehicleName', 'vehicleType', 'vehicleNumber', 'insuranceValidity', "fitnessValidity"];
  data: any = [];
  dataSource = new MatTableDataSource<VehicleModel>(this.data);
  selection = new SelectionModel<VehicleModel>(true, []);
  isLoading: boolean = false;
  selectedRow: any = [];

  constructor(private Apiclient: ApiHandlerService, public dialog: MatDialog) { }

  ngOnInit() {
    this.refresh();
  }
  refresh() {
    this.isLoading = true;
    this.Apiclient.GetAllVehicle().subscribe(data => {
      this.data = data;
      this.isLoading = false;
    })
  }

  /** Whether the number of selected elements matches the total number of rows. */
  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  toggleAllRows() {
    if (this.isAllSelected()) {
      this.selection.clear();
      return;
    }

    this.selection.select(...this.dataSource.data);
  }

  /** The label for the checkbox on the passed row */
  checkboxLabel(row?: VehicleModel): string {
    this.selectedRow = this.selection.selected;
    if (!row) {
      return `${this.isAllSelected() ? 'deselect' : 'select'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row`;
  }

  openDialog() {
    const dialog = this.dialog.open(AddOrUpdataVehicleComponent, { width: '400px', panelClass: 'custom-dialog-container', data: this.selectedRow[0] });
    dialog.afterClosed().subscribe((result: any) => {
      console.log('colsed');
    })
  }

}