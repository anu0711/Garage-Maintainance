import { MatDialog } from '@angular/material/dialog';
import { AddOrUpdataGarageComponent } from './add-or-updata-garage/add-or-updata-garage.component';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ApiHandlerService } from 'src/app/api-handler.service';
import { FormControl, FormGroup } from '@angular/forms';
import { MatPaginator } from '@angular/material/paginator';


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
  displayedColumns: string[] = ['name', 'location'];
  dataSource = new MatTableDataSource(this.garages);
  apiService: any;



  constructor(private http: ApiHandlerService, public dialog: MatDialog) { }


  ngOnInit() {
    this.http.GetAllGarage()
      .subscribe((data: any) => {
        this.garages = Object.values(data);
        this.dataSource = new MatTableDataSource(this.garages);
        console.log(this.dataSource);
      });
  }

  openDialog() {
    const dialog = this.dialog.open(AddOrUpdataGarageComponent, { width: '400px', panelClass: 'custom-dialog-container', data: this.displayedColumns });
    dialog.afterClosed().subscribe((result: any) => {
      console.log('colsed');
    })
  }

}
