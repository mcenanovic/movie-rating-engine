import { NgModule } from "@angular/core";
import { MatInputModule } from '@angular/material/input';
import { MatButtonToggleModule } from '@angular/material/button-toggle';
import { MatButtonModule } from '@angular/material/button';
import { MatSnackBarModule, MAT_SNACK_BAR_DEFAULT_OPTIONS } from '@angular/material/snack-bar';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatDialogModule } from '@angular/material/dialog';

@NgModule({
  imports: [
    MatInputModule,
    MatButtonToggleModule,
    MatButtonModule,
    MatSnackBarModule,
    MatProgressSpinnerModule,
    MatDialogModule,
  ],
  exports: [
    MatInputModule,
    MatButtonToggleModule,
    MatButtonModule,
    MatSnackBarModule,
    MatProgressSpinnerModule,
    MatDialogModule,
  ],
  providers: [
    { provide: MAT_SNACK_BAR_DEFAULT_OPTIONS, useValue: { duration: 2500 } }
  ]
})

export class MaterialModule {}