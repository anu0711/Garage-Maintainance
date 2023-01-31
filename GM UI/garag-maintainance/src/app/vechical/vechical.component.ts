import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';

export interface Vehicle {
  make: string;
  model: string;
  color: string;
  licensePlate: string;
  status: string;
  customername: string;
}

@Component({
  selector: 'app-vechical',
  templateUrl: './vechical.component.html',
  styleUrls: ['./vechical.component.css']
})
export class VechicalComponent implements OnInit {
  displayedColumns: string[] = ['customername', 'make', 'model', 'color', 'licensePlate', 'status'];
  dataSource = new MatTableDataSource<Vehicle>();

  ngOnInit() {
    // Initialize the dataSource with sample data or fetch data from a service
    this.dataSource.data = [
      { customername: 'Source Dinesh', make: 'Toyota', model: 'Camry', color: 'Silver', licensePlate: 'ABC123', status: 'unpaid' },
      { customername: 'Suluku sankar', make: 'Honda', model: 'Civic', color: 'Blue', licensePlate: 'DEF456', status: 'paid' },
      { customername: 'white Dinesh', make: 'Ford', model: 'Mustang', color: 'Red', licensePlate: 'GHI789', status: 'unpaid' }
    ];
  }
  getStatusColor(status: string): string {
    switch (status) {
      case 'paid':
        return 'green';
      case 'unpaid':
        return 'red';
      default:
        return '';
    }
  }
}
