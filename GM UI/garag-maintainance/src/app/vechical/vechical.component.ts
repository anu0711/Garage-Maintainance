import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatTableDataSource } from '@angular/material/table';
import { ApiHandlerService } from 'src/app/api-handler.service';


@Component({
  selector: 'app-vechical',
  template: `
  <table mat-table [dataSource]="dataSource" class="mat-elevation-z8">
    <ng-container matColumnDef="vehicleName">
      <th mat-header-cell *matHeaderCellDef><strong style="font-size: large;">vehicleName</strong></th>
      <td mat-cell *matCellDef="let vehicle"> {{vehicle.vehicleName}} </td>
    </ng-container>
    <ng-container matColumnDef="vehicleType">
      <th mat-header-cell *matHeaderCellDef> <strong style="font-size: large;">vehicleType</strong></th>
      <td mat-cell *matCellDef="let vehicle"> {{vehicle.vehicleType}} </td>
    </ng-container>
    <ng-container matColumnDef="vehicleNumber">
      <th mat-header-cell *matHeaderCellDef><strong style="font-size: large;">vehicleNumber</strong></th>
      <td mat-cell *matCellDef="let vehicle"> {{vehicle.vehicleNumber}} </td>
    </ng-container>
    <ng-container matColumnDef="insuranceValidation">
      <th mat-header-cell *matHeaderCellDef><strong style="font-size: large;">insuranceValidation</strong></th>
      <td mat-cell *matCellDef="let vehicle"> {{vehicle.insuranceValidation}} </td>
    </ng-container>
    <ng-container matColumnDef="fitnessValidity">
      <th mat-header-cell *matHeaderCellDef><strong style="font-size: large;">fitnessValidity</strong></th>
      <td mat-cell *matCellDef="let vehicle"> {{vehicle.fitnessValidity}} </td>
    </ng-container>
    <tr mat-header-row *matHeaderRowDef="displayedColumns"></tr>
    <tr mat-row *matRowDef="let row; columns: displayedColumns;"></tr>
  </table>
`,
  styles: []
})
export class VechicalComponent implements OnInit {

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
