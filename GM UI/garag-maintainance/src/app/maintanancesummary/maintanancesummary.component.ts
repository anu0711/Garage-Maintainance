import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ApiHandlerService } from '../api-handler.service';

@Component({
  selector: 'app-maintanancesummary',
  templateUrl: './maintanancesummary.component.html',
  styleUrls: ['./maintanancesummary.component.css']
})

export class MaintanancesummaryComponent implements OnInit {
  loading: boolean | undefined;
  maintanancesummary: any[] = [];
  displayedColumns: string[] = ['vehicleName', 'vehicleType', 'vehicleNumber', 'detail', 'insuranceValidation', 'fitnessValidity'];
  dataSource = new MatTableDataSource(this.maintanancesummary);


  constructor(private http: ApiHandlerService) { }

  ngOnInit() {
    this.http.GetMaintainanceSummary()
      .subscribe((data: any) => {
        this.maintanancesummary = Object.values(data);
        this.dataSource = new MatTableDataSource(this.maintanancesummary);
        console.log(this.dataSource);
        debugger;
      });


  }
}

