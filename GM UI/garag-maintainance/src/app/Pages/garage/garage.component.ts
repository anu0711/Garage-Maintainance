import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatTableDataSource } from '@angular/material/table';
import { ApiHandlerService } from 'src/app/api-handler.service';


@Component({
  selector: 'app-garage',
  template: `
  <table mat-table [dataSource]="dataSource" class="mat-elevation-z8">
    <ng-container matColumnDef="name">
      <th mat-header-cell *matHeaderCellDef><strong style="font-size: large;">Name</strong></th>
      <td mat-cell *matCellDef="let garage"> {{garage.name}} </td>
    </ng-container>
    <ng-container matColumnDef="location">
      <th mat-header-cell *matHeaderCellDef><strong style="font-size: large;">Location</strong></th>
      <td mat-cell *matCellDef="let garage"> {{garage.location}} </td>
    </ng-container>
    <tr mat-header-row *matHeaderRowDef="displayedColumns"></tr>
    <tr mat-row *matRowDef="let row; columns: displayedColumns;"></tr>
  </table>
`,
  styles: []
})
export class GarageComponent implements OnInit {
  vehicle = {
    vehicleName: '',
    vehicleType: '',
    rcStatus: true,
    vehicleNumber: ''
  };
  garages: any[] = [];
  displayedColumns: string[] = ['name', 'location'];
  dataSource = new MatTableDataSource(this.garages);


  constructor(private http: ApiHandlerService) { }

  ngOnInit() {
    this.http.GetAllGarage()
      .subscribe((data: any) => {
        this.garages = Object.values(data);
        this.dataSource = new MatTableDataSource(this.garages);
        console.log(this.dataSource);
        debugger;
      });


  }
}
