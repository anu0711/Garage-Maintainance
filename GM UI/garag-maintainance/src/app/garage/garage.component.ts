



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

  GetMaintainanceSummary() {
    return this.httpClient.get(this.baseUrl + '/api/Vehicle/GetMaintainanceSummary')
  }


}







