import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ApiHandlerService } from '../api-handler.service';

@Component({
  selector: 'app-dailywork',
  templateUrl: './dailywork.component.html',
  styleUrls: ['./dailywork.component.css']
})

export class DailyworkComponent implements OnInit {

  dailywork: any[] = [];
  displayedColumns: string[] = ['startingKilometer', 'endKilometer', 'number_Of_Loads', 'totalEarnings'];
  dataSource = new MatTableDataSource(this.dailywork);


  constructor(private http: ApiHandlerService) { }

  ngOnInit() {
    this.http.GetAllDailywork()
      .subscribe((data: any) => {
        this.dailywork = Object.values(data);
        this.dataSource = new MatTableDataSource(this.dailywork);
        console.log(this.dataSource);
      });
  }
}
