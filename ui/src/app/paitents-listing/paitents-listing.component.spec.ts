import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaitentsListingComponent } from './paitents-listing.component';

describe('PaitentsListingComponent', () => {
  let component: PaitentsListingComponent;
  let fixture: ComponentFixture<PaitentsListingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PaitentsListingComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(PaitentsListingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
