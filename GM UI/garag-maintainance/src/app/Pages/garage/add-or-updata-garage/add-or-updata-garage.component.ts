import { Component, Inject } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-add-or-updata-garage',
  templateUrl: './add-or-updata-garage.component.html',
  styleUrls: ['./add-or-updata-garage.component.css']
})
export class AddOrUpdataGarageComponent {

  isEdit: boolean;

  constructor(public dialogRef: MatDialogRef<AddOrUpdataGarageComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any, public fb: FormBuilder) {
    this.isEdit = false
  }
  form = new FormGroup({
    name: new FormControl('', [Validators.required]),
    location: new FormControl('', [Validators.required])
  })

  get name() {
    return this.form.get('name');
  }
  get location() {
    return this.form.get('location');
  }

  onFormSubmit() {
    console.log(this.form.value);
  }

}
