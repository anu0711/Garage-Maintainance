import { ApiHandlerService } from 'src/app/api-handler.service';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { VehicleModel } from '../vechical.component';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-add-or-updata-vehicle',
  templateUrl: './add-or-updata-vehicle.component.html',
  styleUrls: ['./add-or-updata-vehicle.component.css']
})
export class AddOrUpdataVehicleComponent {
  isEdit: boolean = false;
  form: any;
  constructor(public dialogRef: MatDialogRef<AddOrUpdataVehicleComponent>,
    @Inject(MAT_DIALOG_DATA) public data: VehicleModel, public fb: FormBuilder, public ApiClient: ApiHandlerService, private DatePipe: DatePipe) {
    debugger;
    if (data != undefined)
      this.isEdit = true
    this.form = new FormGroup({
      vehicleName: new FormControl(this.isEdit ? this.data.vehicleName : '', [Validators.required]),
      vehicleType: new FormControl(this.isEdit ? this.data.vehicleType : '', [Validators.required]),
      vehicleNumber: new FormControl(this.isEdit ? this.data.vehicleNumber : '', Validators.required),
      insuranceValidation: new FormControl(this.isEdit ? this.data.insuranceValidity : '', [Validators.required]),
      fitnessValidation: new FormControl(this.isEdit ? this.data.fitnessValidity : '', Validators.required)
    })
  }

  get vehicleName() {
    return this.form.get('vehicleName');
  }
  get vehicleType() {
    return this.form.get('vehicleType');
  }
  get vehicleNumber() {
    return this.form.get('vehicleNumber');
  }
  get insuranceValidation() {
    return this.form.get('insuranceValidation');
  }
  get fitnessValidation() {
    return this.form.get('fitnessValidation');
  }

  onFormSubmit() {
    var { vehicleName, vehicleType, vehicleNumber, insuranceValidation, fitnessValidation } = this.form.value;
    debugger;
    var body: any = {
      vehicleName: vehicleName,
      vehicleType: vehicleType,
      vehicleNumber: vehicleNumber,
      insuranceValidity: insuranceValidation,
      fitnessValidity: fitnessValidation
    };
    console.log(body);
    debugger;
    if (this.isEdit) {
      body.id = this.data.id;
    }
    this.ApiClient.addOrUpdateVehicle(body).subscribe(data => {
      console.log(data);
      debugger
    })

  }

}
