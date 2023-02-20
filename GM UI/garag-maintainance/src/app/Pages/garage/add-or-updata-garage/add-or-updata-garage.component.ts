import { Component, Inject } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-add-or-updata-garage',
  templateUrl: './add-or-updata-garage.component.html',
  styleUrls: ['./add-or-updata-garage.component.css']
})
export class AddOrUpdataGarageComponent {

  isEdit: boolean = true;


  constructor(public dialogRef: MatDialogRef<AddOrUpdataGarageComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any, public fb: FormBuilder, private http: HttpClient) {
    if (this.data != undefined)
      this.isEdit = true
    debugger;
  }
  form = new FormGroup({
    name: new FormControl(this.isEdit ? this.data.name : '', [Validators.required]),
    location: new FormControl(this.isEdit ? this.data.location : '', [Validators.required])
  })

  get name() {
    return this.form.get('name');
  }
  get location() {
    return this.form.get('location');
  }

  onFormSubmit() {
    const url = 'https://localhost:7123/api/Garage/AddorUpdateGarage';
    this.http.post(url, this.form.value)
      .subscribe(response => {
        console.log(response);
        location.reload();
      });
  }
}
