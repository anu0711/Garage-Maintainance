import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatDatepickerInputEvent } from '@angular/material/datepicker';

@Component({
  selector: 'app-add-or-updata-vehicle',
  templateUrl: './add-or-updata-vehicle.component.html',
  styleUrls: ['./add-or-updata-vehicle.component.css']
})
export class AddOrUpdataVehicleComponent {
  isEdit: boolean;

  constructor(public dialogRef: MatDialogRef<AddOrUpdataVehicleComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any, public fb: FormBuilder) {
    this.isEdit = false
  }
  form = new FormGroup({
    vehicleName: new FormControl('', [Validators.required]),
    vehicleType: new FormControl('', [Validators.required]),
    vehicleNumber: new FormControl('', Validators.required),
    insuranceValidation: new FormControl('', [Validators.required]),
    fitnessValidation: new FormControl('', Validators.required)
  })

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
    console.log(this.form.value)
  }

}
