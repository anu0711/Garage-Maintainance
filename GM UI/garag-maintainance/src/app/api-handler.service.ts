import { HttpClient } from '@angular/common/http';
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



  GetAllGarage() {
    return this.httpClient.get(this.baseUrl + '/api/Garage/GetAllGarage')
  }
  GetAllVehicle() {
    return this.httpClient.get(this.baseUrl + '/api/Vehicle/GetAllvehicle')
  }

  // Addvehichel(vehicle: any) {
  //   return this.httpClient.post(this.baseUrl + '/api/Vehicle/AddorUpdateVehicle', {})
  // }

}
