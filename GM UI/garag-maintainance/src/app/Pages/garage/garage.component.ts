import { ApiHandlerService } from './../../api-handler.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-garage',
  templateUrl: './garage.component.html',
  styleUrls: ['./garage.component.css']
})
export class GarageComponent implements OnInit {

  data: any | undefined;
  dataColumn: string[] = ["Sno", "title", "body"];
  loading = false;
  constructor(private apiClient: ApiHandlerService) { }

  ngOnInit() {
    this.loading = true;
    this.apiClient.getData().subscribe(data => {
      this.data = data;
      this.loading = false;
    });
  }

}
