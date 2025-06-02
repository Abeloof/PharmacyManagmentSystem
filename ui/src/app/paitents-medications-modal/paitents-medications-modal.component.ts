import { AfterViewInit, ChangeDetectionStrategy, Component, Inject, ViewChild } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MAT_DIALOG_DATA, MatDialogModule, MatDialog } from '@angular/material/dialog';
import { Medication } from '../models/medication.model';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { Paitent } from '../models/paitent.model';

@Component({
  selector: 'app-paitents-medications-modal',
  imports: [MatDialogModule, MatButtonModule, MatTableModule, MatPaginatorModule],
  template: `
    <h2 mat-dialog-title>{{patient.firstName}} {{patient.lastName}} Medications</h2>
    <mat-dialog-content class="mat-typography">
      <div class="mat-elevation-z8 pms-table">
        <table mat-table [dataSource]="medications">
          <!-- Position patientId -->
          <ng-container matColumnDef="medicationId">
            <th mat-header-cell *matHeaderCellDef> Medication Id </th>
            <td mat-cell *matCellDef="let element"> {{element.medicationId}} </td>
          </ng-container>
          <!-- Name firstName -->
          <ng-container matColumnDef="medicationName">
            <th mat-header-cell *matHeaderCellDef> Medication Name </th>
            <td mat-cell *matCellDef="let element"> {{element.medicationName}} </td>
          </ng-container>
          <!-- Weight Column -->
          <ng-container matColumnDef="dose">
            <th mat-header-cell *matHeaderCellDef> Dose </th>
            <td mat-cell *matCellDef="let element"> {{element.dose}} </td>
          </ng-container>
          <!-- Symbol dateOfBirth -->
          <ng-container matColumnDef="isGeneric">
            <th mat-header-cell *matHeaderCellDef> isGeneric </th>
            <td mat-cell *matCellDef="let element"> {{element.isGeneric ? "Yes" : "No" }} </td>
          </ng-container>
          <!-- Symbol insuranceId  -->
          <ng-container matColumnDef="instruction" >
            <th mat-header-cell *matHeaderCellDef> instruction </th>
            <td mat-cell *matCellDef="let element"> {{element.instruction}} </td>
          </ng-container>
          <!-- Symbol medications count  -->
          <ng-container matColumnDef="refilAmmount" >
            <th mat-header-cell *matHeaderCellDef> Refil Ammount </th>
            <td mat-cell *matCellDef="let element"> {{ element.refilAmmount }} </td>
          </ng-container>
          <ng-container matColumnDef="frequency" >
            <th mat-header-cell *matHeaderCellDef> Frequency </th>
            <td mat-cell *matCellDef="let element"> {{ element.frequency }} </td>
          </ng-container>
          <ng-container matColumnDef="cost" >
            <th mat-header-cell *matHeaderCellDef> Cost </th>
            <td mat-cell *matCellDef="let element"> {{ element.cost }} </td>
          </ng-container>
          <ng-container matColumnDef="prescriberId" >
            <th mat-header-cell *matHeaderCellDef> Prescriber Id </th>
            <td mat-cell *matCellDef="let element"> {{ element.prescriberId }} </td>
          </ng-container>
          <ng-container matColumnDef="pharmacyId" >
            <th mat-header-cell *matHeaderCellDef> Pharmacy Id </th>
            <td mat-cell *matCellDef="let element"> {{ element.pharmacyId }} </td>
          </ng-container>
          <tr mat-header-row *matHeaderRowDef="displayedColumns"></tr>
          <tr mat-row *matRowDef="let row; columns: displayedColumns;"
          ></tr>
        </table>
        <mat-paginator [pageSizeOptions]="[5]"
                      showFirstLastButtons
                      aria-label="Select page of periodic elements">
        </mat-paginator>
      </div>
    </mat-dialog-content>
    <mat-dialog-actions align="end">
      <button matButton mat-dialog-close>Close</button>
    </mat-dialog-actions>

  `,
  styles: ``,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class PaitentsMedicationsModalComponent implements AfterViewInit {
  displayedColumns: string[] = ['medicationId', 'medicationName', 'dose', 'isGeneric', 'instruction', 'refilAmmount', 'frequency', 'cost', 'prescriberId', 'pharmacyId'];
  dataSource = new MatTableDataSource<Medication>();
  patient: Paitent;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  constructor(@Inject(MAT_DIALOG_DATA) public medications: Medication[]) {
    this.patient = medications[0].patient;
    this.dataSource.data = medications;
  }

  ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
  }
}
