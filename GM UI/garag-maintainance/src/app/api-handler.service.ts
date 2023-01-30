import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiHandlerService {

  baseUrl: string = 'https://jsonplaceholder.typicode.com';
  constructor(private httpClient: HttpClient) { }

  getData() {
    return this.httpClient.get(this.baseUrl + '/posts');
  }

}
