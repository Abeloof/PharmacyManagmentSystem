import { AfterViewInit, Component, inject, OnInit, ViewChild } from '@angular/core';
import { PatientsService } from '../services/patients.service';
import { LoadingState } from '../app.constants';
import { Paitent } from '../models/paitent.model';
import { MatProgressSpinner } from '@angular/material/progress-spinner';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatDialog, MatDialogConfig, MatDialogModule } from '@angular/material/dialog';
import { PaitentsMedicationsModalComponent } from '../paitents-medications-modal/paitents-medications-modal.component';
import { CommonModule } from '@angular/common';
import { Medication } from '../models/medication.model';

@Component({
  selector: 'app-paitents-listing',
  imports: [MatProgressSpinner, MatPaginatorModule, MatTableModule, MatDialogModule, CommonModule],
  template: `
    @if (loading === LoadingState.LOADING) {
      <mat-spinner></mat-spinner>
    }
    @if (loading === LoadingState.FAILED) {
      <mat-spinner></mat-spinner>
    }
    <div class="mat-elevation-z8 pms-table" *ngIf="loading != LoadingState.LOADING && loading != LoadingState.FAILED">
      <table mat-table [dataSource]="patients">

        <!-- Position patientId -->
        <ng-container matColumnDef="patientId">
          <th mat-header-cell *matHeaderCellDef> Patient Id </th>
          <td mat-cell *matCellDef="let element"> {{element.patientId}} </td>
        </ng-container>

        <!-- Name firstName -->
        <ng-container matColumnDef="firstName">
          <th mat-header-cell *matHeaderCellDef> First Name </th>
          <td mat-cell *matCellDef="let element"> {{element.firstName}} </td>
        </ng-container>

        <!-- Weight Column -->
        <ng-container matColumnDef="lastName">
          <th mat-header-cell *matHeaderCellDef> Last Name </th>
          <td mat-cell *matCellDef="let element"> {{element.lastName}} </td>
        </ng-container>

        <!-- Symbol dateOfBirth -->
        <ng-container matColumnDef="dateOfBirth">
          <th mat-header-cell *matHeaderCellDef> Dob </th>
          <td mat-cell *matCellDef="let element"> {{element.dateOfBirth}} </td>
        </ng-container>

        <!-- Symbol insuranceId  -->
        <ng-container matColumnDef="insuranceId" >
          <th mat-header-cell *matHeaderCellDef> Insurance Id </th>
          <td mat-cell *matCellDef="let element"> {{ element.isEnsured ? element.insuranceId : "none" }} </td>
        </ng-container>

        <!-- Symbol medications count  -->
        <ng-container matColumnDef="medications" >
          <th mat-header-cell *matHeaderCellDef> Total Medications </th>
          <td mat-cell *matCellDef="let element"> {{ element.medications.length }} </td>
        </ng-container>

        <tr mat-header-row *matHeaderRowDef="displayedColumns"></tr>
        <tr
            mat-row
            (click)="onClickRow(row)"
            *matRowDef="let row; columns: displayedColumns;"
        ></tr>
      </table>

      <mat-paginator [pageSizeOptions]="[5, 10, 20]"
                    showFirstLastButtons
                    aria-label="Select page of periodic elements">
      </mat-paginator>
    </div>
  `,
  styles: `
      .pms-table {
        width: 100%;
      }
      .mat-mdc-row .mat-mdc-cell {
        border-bottom: 1px solid transparent;
        border-top: 1px solid transparent;
        cursor: pointer;
      }
      .mat-mdc-row:hover .mat-mdc-cell {
        border-color: currentColor;
        background-color: bisque;
      }
  `
})

export class PaitentsListingComponent implements OnInit, AfterViewInit {
  LoadingState = LoadingState
  loading = LoadingState.NOT_LOADED;
  displayedColumns: string[] = ['patientId', 'firstName', 'lastName', 'dateOfBirth', 'insuranceId', 'medications'];
  dataSource = new MatTableDataSource<Paitent>();
  patients: Paitent[] = [];
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  readonly dialog = inject(MatDialog);
  input = new MatDialogConfig<Medication[]>();

  constructor(private patientService: PatientsService) { }

  ngOnInit() {
    this.loading = LoadingState.LOADING;
    this.patientService
      .getAllPatients()
      .subscribe({
        next: (data) => {
          this.loading = LoadingState.LOADED;
          this.patients = data;
          this.dataSource.data = this.patients;
        },
        error: (err) => {
          this.loading = this.LoadingState.FAILED;
        }
      });
  }

  ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
  }

  onClickRow(e: Paitent): void {
    e.medications[0].patient = e;
    this.input.data = e.medications;
    this.input.height = `${window.innerHeight}px`;
    this.input.width = `${window.innerWidth}px`;
    this.input.maxWidth = `${window.innerWidth - (window.innerWidth * 1 / 5)}px`;
    this.input.maxHeight = `${window.innerHeight - (window.innerHeight * 1 / 5)}px`;
    const dialogRef = this.dialog.open(PaitentsMedicationsModalComponent, this.input);
  }
}
