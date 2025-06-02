import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MatTabsModule } from '@angular/material/tabs';
import { PaitentsListingComponent } from './paitents-listing/paitents-listing.component';
import { AddPatientsMedicationsComponent } from './add-patients-medications/add-patients-medications.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, MatTabsModule, PaitentsListingComponent, AddPatientsMedicationsComponent],
  template: `
    <mat-tab-group animationDuration="0ms">
      <mat-tab label="View Patient Medications">
        <app-paitents-listing></app-paitents-listing>
      </mat-tab>
      <mat-tab label="Addd Patient Medications">
        <app-add-patients-medications></app-add-patients-medications>
      </mat-tab>
    </mat-tab-group>
    <router-outlet />
  `,
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Pharmacy Mangement System';
}
