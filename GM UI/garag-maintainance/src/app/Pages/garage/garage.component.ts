import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ApiHandlerService } from 'src/app/api-handler.service';
import { FormControl, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-garage',
  template: `
  <ng-container *ngIf="loading">
    <mat-progress-bar mode="indeterminate"></mat-progress-bar>
</ng-container>
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
     <form [formGroup]="garageForm" (ngSubmit)="submitForm()">
    <div>
      <mat-form-field>
        <input matInput placeholder="Name" formControlName="name">
      </mat-form-field>
    </div>
    <div>
      <mat-form-field>
        <input matInput placeholder="Location" formControlName="location">
      </mat-form-field>
    </div>
    <button mat-raised-button color="primary">{{formType}} Garage</button>
  </form>
`,
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


  constructor(private http: ApiHandlerService) { }

  ngOnInit() {
    this.garageForm = new FormGroup({
      name: new FormControl(''),
      location: new FormControl(''),
    });


    this.http.GetAllGarage()
      .subscribe((data: any) => {
        this.garages = Object.values(data);
        this.dataSource = new MatTableDataSource(this.garages);
        console.log(this.dataSource);
        debugger;
      });


  }
  submitForm() {
    if (this.formType === 'Add') {
      this.apiService.AddGarage(this.garageForm.value).subscribe((response: any) => {
        console.log(response);
      });
    } else if (this.formType === 'Update') {
      this.apiService.UpdateGarage(this.garageForm.value).subscribe((response: any) => {
        console.log(response);
      });
    }
  }
}
