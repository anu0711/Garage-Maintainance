import { VehicleModel } from './vechical/vechical.component';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiHandlerService {


  baseUrl: string = 'https://localhost:7123';
  constructor(private httpClient: HttpClient) { }

  getData() {
    return this.httpClient.get(this.baseUrl + '/posts');
  }

  GetDashBoardDetails() {
    return this.httpClient.get(this.baseUrl + '/api/Vehicle/GetAllDashbord')
  }

  GetAllGarage() {
    return this.httpClient.get(this.baseUrl + '/api/Garage/GetAllGarage')
  }
  GetAllVehicle() {
    return this.httpClient.get(this.baseUrl + '/api/Vehicle/GetAllvehicle')
  }
  GetAllDailywork() {
    return this.httpClient.get(this.baseUrl + '/api/DailyWork/GetAllDailyWork')
  }
  GetMaintainanceSummary() {
    return this.httpClient.get(this.baseUrl + '/api/Vehicle/GetMaintainanceSummary')

  }
  addOrUpdateGarage(garage: any) {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json'
    });

    return this.httpClient.post(this.baseUrl + '/api/Garage/AddorUpdateGarage', garage, { headers });
  }
  addOrUpdateVehicle(Vehicle: VehicleModel) {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json'
    });
    return this.httpClient.post(this.baseUrl + '/api/Vehicle/AddorUpdateVehicle', Vehicle);
  }

}
