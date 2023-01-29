import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';

export interface Vehicle {
  make: string;
  model: string;
  color: string;
  licensePlate: string;
}

@Component({
  selector: 'app-vechical',
  templateUrl: './vechical.component.html',
  styleUrls: ['./vechical.component.css']
})
export class VechicalComponent implements OnInit {
  displayedColumns: string[] = ['make', 'model', 'color', 'licensePlate'];
  dataSource = new MatTableDataSource<Vehicle>();

  ngOnInit() {
    // Initialize the dataSource with sample data or fetch data from a service
    this.dataSource.data = [
      { make: 'Toyota', model: 'Camry', color: 'Silver', licensePlate: 'ABC123' },
      { make: 'Honda', model: 'Civic', color: 'Blue', licensePlate: 'DEF456' },
      { make: 'Ford', model: 'Mustang', color: 'Red', licensePlate: 'GHI789' }
    ];
  }

}
