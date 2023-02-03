import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatTableDataSource } from '@angular/material/table';
import { ApiHandlerService } from 'src/app/api-handler.service';


@Component({
  selector: 'app-garage',
  template: `
    <!-- Add a template for displaying the data from the API -->
  `,
  styles: []
})
export class GarageComponent implements OnInit {
  garages: any[] = [];
  displayedColumns: string[] = ['id', 'vehicleName'];
  dataSource = new MatTableDataSource(this.garages);


  constructor(private http: ApiHandlerService) { }

  ngOnInit() {
    this.http.GetMaintainanceSummary()
      .subscribe((data: { [s: string]: any; } | ArrayLike<any>) => {
        this.garages = Object.values(data);
        this.dataSource = new MatTableDataSource(this.garages);
        console.log(this.dataSource);
        debugger;
      });
  }
}
