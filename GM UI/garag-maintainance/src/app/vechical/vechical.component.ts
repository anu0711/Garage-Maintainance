import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatTableDataSource } from '@angular/material/table';
import { ApiHandlerService } from 'src/app/api-handler.service';


@Component({
  selector: 'app-vechical',
  templateUrl: 'vechical.component.html',
  styles: []
})
export class VechicalComponent implements OnInit {
  loading: boolean | undefined;
  vehicles: any[] = [];
  displayedColumns: string[] = ['vehicleName', 'vehicleType', 'vehicleNumber', 'insuranceValidation', 'fitnessValidity'];
  dataSource = new MatTableDataSource(this.vehicles);


  constructor(private http: ApiHandlerService) { }

  ngOnInit() {
    this.http.GetAllVehicle()
      .subscribe((data: any) => {
        this.vehicles = Object.values(data);
        this.dataSource = new MatTableDataSource(this.vehicles);
        console.log(this.dataSource);
        debugger;
      });


  }
}
