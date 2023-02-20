import { MatDialog } from '@angular/material/dialog';
import { AddOrUpdataGarageComponent } from './add-or-updata-garage/add-or-updata-garage.component';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ApiHandlerService } from 'src/app/api-handler.service';
import { SelectionModel } from '@angular/cdk/collections';

export interface GarageModel {
  location: string,
  name: string
}
@Component({
  selector: 'app-garage',
  templateUrl: './garage.component.html',
  styles: []
})


export class GarageComponent implements OnInit {
  loading: boolean | undefined
  garageForm: any;
  formType = 'Add';


  vehicle = {
    vehicleName: '',
    vehicleType: '',
    rcStatus: true,
    vehicleNumber: ''
  };
  garages: any[] = [];
  displayedColumns: string[] = ['select', 'name', 'location'];
  dataSource = new MatTableDataSource(this.garages);
  apiService: any;
  selection = new SelectionModel<GarageModel>(true, []);
  selectedRow: any = [];




  constructor(private http: ApiHandlerService, public dialog: MatDialog) { }


  ngOnInit() {
    this.http.GetAllGarage()
      .subscribe((data: any) => {
        this.garages = Object.values(data);
        this.dataSource = new MatTableDataSource(this.garages);
        console.log(this.dataSource);
      });
  }



  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }


  toggleAllRows() {
    if (this.isAllSelected()) {
      this.selection.clear();
      return;
    }

    this.selection.select(...this.dataSource.data);
  }


  checkboxLabel(row?: GarageModel): string {
    this.selectedRow = this.selection.selected;
    if (!row) {
      return `${this.isAllSelected() ? 'deselect' : 'select'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row`;
  }

  openDialog() {
    const dialog = this.dialog.open(AddOrUpdataGarageComponent, { width: '400px', panelClass: 'custom-dialog-container', data: this.selectedRow[0] });
    dialog.afterClosed().subscribe((result: any) => {
      console.log('colsed');
    })
  }

}
