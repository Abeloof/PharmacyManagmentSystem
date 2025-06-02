import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaitentsMedicationsModalComponent } from './paitents-medications-modal.component';

describe('PaitentsMedicationsModalComponent', () => {
  let component: PaitentsMedicationsModalComponent;
  let fixture: ComponentFixture<PaitentsMedicationsModalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PaitentsMedicationsModalComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(PaitentsMedicationsModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
