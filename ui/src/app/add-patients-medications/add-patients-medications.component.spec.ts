import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddPatientsMedicationsComponent } from './add-patients-medications.component';

describe('AddPatientsMedicationsComponent', () => {
  let component: AddPatientsMedicationsComponent;
  let fixture: ComponentFixture<AddPatientsMedicationsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddPatientsMedicationsComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(AddPatientsMedicationsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
