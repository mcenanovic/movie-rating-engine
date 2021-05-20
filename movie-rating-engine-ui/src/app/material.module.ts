import { NgModule } from "@angular/core";
import { MatInputModule } from '@angular/material/input';
import { MatButtonToggleModule } from '@angular/material/button-toggle';
import { MatButtonModule } from '@angular/material/button';

@NgModule({
  imports: [
    MatInputModule,
    MatButtonToggleModule,
    MatButtonModule,
  ],
  exports: [
    MatInputModule,
    MatButtonToggleModule,
    MatButtonModule,
  ]
})

export class MaterialModule {}