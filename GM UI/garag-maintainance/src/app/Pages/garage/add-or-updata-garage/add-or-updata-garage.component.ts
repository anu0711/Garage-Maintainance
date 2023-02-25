import { MessageHandlerService } from './../../../message-handler.service';
import { GarageModel } from './../garage.component';
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

  isEdit: boolean = false;
  form: any

  constructor(public dialogRef: MatDialogRef<AddOrUpdataGarageComponent>,
    @Inject(MAT_DIALOG_DATA) public data: GarageModel, public fb: FormBuilder, private http: HttpClient, private MessageBar: MessageHandlerService) {
    if (this.data != undefined)
      this.isEdit = true;
    this.form = new FormGroup({
      name: new FormControl(this.isEdit ? this.data.name : '', [Validators.required]),
      location: new FormControl(this.isEdit ? this.data.location : '', [Validators.required])
    })
  }

  get name() {
    return this.form.get('name');
  }
  get location() {
    return this.form.get('location');
  }

  onFormSubmit() {
    const url = 'https://localhost:7123/api/Garage/AddorUpdateGarage';
    var { name, location } = this.form.value;
    var body: any = {
      isActive: true,
      location: location,
      name: name
    }
    if (this.isEdit) {
      body.id = this.data.id;
      body.createdBy = this.data.createdBy;
      body.createdDate = this.data.createdDate;
      body.updatedBy = this.data.updatedBy;
      body.updatedDate = this.data.updatedDate
    }

    this.http.post(url, body)
      .subscribe(response => {
        console.log(response);
      });
    if (this.isEdit)
      this.MessageBar.success("Edited successfully");
    else
      this.MessageBar.success("Added Successsfully")
    this.dialogRef.close()

  }
}
