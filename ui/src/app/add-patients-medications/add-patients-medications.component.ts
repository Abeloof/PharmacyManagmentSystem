import { Component, inject, ChangeDetectionStrategy } from '@angular/core';
import { FormBuilder, Validators, FormsModule, ReactiveFormsModule, FormGroup, FormControlStatus } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatStepper, MatStepperModule } from '@angular/material/stepper';
import { MatButtonModule } from '@angular/material/button';
import { provideNativeDateAdapter } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { CommonModule } from '@angular/common';
import { MatProgressSpinner } from '@angular/material/progress-spinner';
import { PatientsService } from '../services/patients.service';
import { Paitent } from '../models/paitent.model';

@Component({
  selector: 'app-add-patients-medications',
  imports: [MatButtonModule, MatStepperModule, FormsModule, ReactiveFormsModule,
    MatFormFieldModule, MatInputModule, MatDatepickerModule, CommonModule, MatProgressSpinner],
  providers: [provideNativeDateAdapter()],
  template: `
    @if (isSubmitted) {
      <mat-spinner></mat-spinner>
    }
    <div *ngIf="!isSubmitted">
    <mat-stepper [linear]="isLinear" #stepper>
      <mat-step [stepControl]="firstFormGroup">
        <form [formGroup]="firstFormGroup">
            <ng-template matStepLabel>Patient Information</ng-template>
              <table class="pms-full-width" cellspacing="0"><tr>
                <!-- <td>
                  <mat-form-field>
                    <mat-label>Patient Id</mat-label>
                    <input matInput placeholder="patient Id" formControlName="patientId" required>
                  </mat-form-field>
                </td> -->
                <td>
                  <mat-form-field>
                    <mat-label>Patient First Name</mat-label>
                    <input matInput placeholder="first name" formControlName="firstName" required>
                  </mat-form-field>
                </td>
                <td>
                  <mat-form-field>
                    <mat-label>Patient Last Name</mat-label>
                    <input matInput placeholder="last name" formControlName="lastName" required>
                  </mat-form-field>
                </td>
                <td>
                  <mat-form-field>
                    <mat-label>Patient Birth Date</mat-label>
                    <input matInput [matDatepicker]="picker" formControlName="dateOfBirth" required>
                    <mat-hint>MM/DD/YYYY</mat-hint>
                    <mat-datepicker-toggle matIconSuffix [for]="picker"></mat-datepicker-toggle>
                    <mat-datepicker #picker></mat-datepicker>
                  </mat-form-field>
                </td>
                <td>
                    <mat-form-field>
                      <mat-label>Patient Insurance Id</mat-label>
                      <input matInput placeholder="Insurance Id" formControlName="insuranceId">
                    </mat-form-field>
                </td>
              </tr></table>
              <div class="mat-step-label">
                <button matButton matStepperNext [disabled]=firstFormGroupNextDisabled>Next</button>
              </div>
        </form>
      </mat-step>
      <mat-step [stepControl]="secondFormGroup" label="Medication infromation">
        <form [formGroup]="secondFormGroup">
          <table class="pms-full-width" cellspacing="0"><tr>
           <!-- <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Medication Id</mat-label>
                <input matInput formControlName="medicationId" placeholder="Medication Id" required>
              </mat-form-field>
            </td> -->
            <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Medication Name</mat-label>
                <input matInput formControlName="medicationName" placeholder="Medication Name" required>
              </mat-form-field>
            </td>
            <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Medication dose</mat-label>
                <input matInput formControlName="dose" placeholder="Medication dose" required>
              </mat-form-field>
            </td>
            <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Medication Instruction</mat-label>
                <input matInput formControlName="instruction" placeholder="Medication Instruction" required>
              </mat-form-field>
            </td>
          </tr></table>
          <table class="pms-full-width" cellspacing="0"><tr>
            <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Medication refill amount</mat-label>
                <input matInput formControlName="refillAmount" placeholder="Medication refill amount" required>
              </mat-form-field>
            </td>
            <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Medication frequency</mat-label>
                <input matInput formControlName="frequency" placeholder="Medication frequency" required>
              </mat-form-field>
            </td>
            <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Medication cost</mat-label>
                <input matInput formControlName="cost" placeholder="Medication cost" required>
              </mat-form-field>
            </td>
          </tr></table>
          <div>
            <button matButton matStepperPrevious>Back</button>
            <button matButton matStepperNext [disabled]=secondFormGroupNextDisabled>Next</button>
          </div>
        </form>
      </mat-step>
      <mat-step>
        <ng-template matStepLabel>Pharmacy and Provider Information</ng-template>
        <form [formGroup]="thrdFormGroup">
          <table class="pms-full-width" cellspacing="0"><tr>
            <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Pharmacy Name</mat-label>
                <input matInput formControlName="name" placeholder="Pharmacy Name" required>
              </mat-form-field>
            </td>
            <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Pharmacy State</mat-label>
                <select matNativeControl formControlName="state" required>
                  <option value="VA">Virginia</option>
                  <option value="MD">Maryland</option>
                  <option value="NJ">New Jersey</option>
                  <option value="NY">New York</option>
                </select>
              </mat-form-field>
            </td>
            <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Pharmacy City</mat-label>
                <select matNativeControl formControlName="city" required>
                  <option value="Arlington">Arlington</option>
                  <option value="Baltimore">Baltimore</option>
                  <option value="Jersy">South Jersey</option>
                  <option value="Bronx">Bronx</option>
                </select>
              </mat-form-field>
            </td>
          </tr></table>
          <table class="pms-full-width" cellspacing="0"><tr>
            <!-- <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Prescriber Id</mat-label>
                <input matInput formControlName="prescriberId" placeholder="Prescriber NPI" required>
              </mat-form-field>
            </td> -->
            <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Prescriber First Name</mat-label>
                <input matInput formControlName="firstName" placeholder="Prescriber First Name" required>
              </mat-form-field>
            </td>
            <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Prescriber Last Name</mat-label>
                <input matInput formControlName="lastName" placeholder="Prescriber Last Name" required>
              </mat-form-field>
            </td>
            <td>
              <mat-form-field class="pms-full-width">
                <mat-label>Prescriber NPI</mat-label>
                <input matInput formControlName="speciality" placeholder="Prescriber NPI" required>
              </mat-form-field>
            </td>
          </tr></table>
        </form>
        <div>
          <button matButton matStepperPrevious>Back</button>
          <button matButton (click)="onSubmit(stepper)" [disabled]=thirdFormGroupNextDisabled>Submit</button>
        </div>
      </mat-step>
    </mat-stepper>
  </div>
  `,
  styles: `
    .pms-form {
      min-width: 150px;
      max-width: 500px;
      width: 100%;
    }

    .pms-full-width {
      width: 100%;
    }

    td {
      padding-right: 8px;
    }
    .mat-stepper-horizontal {
      margin-top: 8px;
    }

    .mat-mdc-form-field {
      margin-top: 16px;
    }
  `,
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class AddPatientsMedicationsComponent {
  private _formBuilder = inject(FormBuilder);

  firstFormGroup: FormGroup<any>;
  firstFormGroupNextDisabled: boolean = true;
  secondFormGroup: FormGroup<any>;
  secondFormGroupNextDisabled: boolean = true;
  thrdFormGroup: FormGroup<any>;
  thirdFormGroupNextDisabled: boolean = true;
  isLinear = false;
  isSubmitted = false;
  constructor(private patientService: PatientsService) {
    this.firstFormGroup = this._formBuilder.group({
      //patientId: ['', { validators: [Validators.required] }],
      firstName: ['', { validators: [Validators.required] }],
      lastName: ['', { validators: [Validators.required] }],
      dateOfBirth: ['', { validators: Validators.required }],
      insuranceId: ['', { validators: Validators.pattern("\s+|\w+") }]
    });
    this.OnFormGroupChanged(this.firstFormGroup, (val: boolean) => this.firstFormGroupNextDisabled = val);
    this.secondFormGroup = this._formBuilder.group({
      //medicationId: ['', Validators.required],
      medicationName: ['', Validators.required],
      dose: ['', Validators.required],
      instruction: ['', Validators.required],
      refillAmount: ['', Validators.required],
      frequency: ['', Validators.required],
      cost: ['', Validators.required]
    });
    this.OnFormGroupChanged(this.secondFormGroup, (val: boolean) => this.secondFormGroupNextDisabled = val);
    this.thrdFormGroup = this._formBuilder.group({
      name: ['', Validators.required],
      state: ['', Validators.required],
      city: ['', Validators.required],
      //prescriberId: ['', Validators.required],
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      speciality: ['', Validators.required]
    });
    this.OnFormGroupChanged(this.thrdFormGroup, (val: boolean) => this.thirdFormGroupNextDisabled = val);
  }

  onSubmit(stepper: MatStepper) {
    this.isSubmitted = true;
    let patient: Paitent = {
      ... this.firstFormGroup.value,
      medications: [
        {
          ... this.secondFormGroup.value,
          pharmacy: { ... this.thrdFormGroup.value },
          prescriber: { ... this.thrdFormGroup.value }
        }
      ]
    }
    this.patientService.addPatient(patient)
      .subscribe((result) => {
        if (result) {
          stepper.reset();
          stepper.next();
          this.isSubmitted = false;
        }
      })
  }
  OnFormGroupChanged(formGroup: FormGroup, func: (val: boolean) => boolean) {
    formGroup.statusChanges
      .subscribe((value: FormControlStatus) => {
        if (value == "VALID")
          func(false);
      });
  }
}
