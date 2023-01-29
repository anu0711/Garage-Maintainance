import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
  providedIn: 'root'
})
export class MessageHandlerService {

  constructor(private _snackBar: MatSnackBar) { }

  error(message: string) {
    this._snackBar.open(message, "Dismiss", {
      panelClass: ['snackbar-error'],
      horizontalPosition: 'center',
      verticalPosition: 'top',
      duration: 5000
    })
  }

  success(message: string) {
    this._snackBar.open(message, 'Dismiss', {
      panelClass: ['snackbar-success'],
      horizontalPosition: 'center',
      verticalPosition: 'top',
      duration: 5000
    })
  }

  info(message: string) {
    this._snackBar.open(message, 'Dismiss', {
      panelClass: ['snackbar-info'],
      horizontalPosition: 'center',
      verticalPosition: 'top',
      duration: 5000
    })
  }

}
