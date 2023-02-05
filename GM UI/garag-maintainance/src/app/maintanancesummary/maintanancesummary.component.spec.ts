import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MaintanancesummaryComponent } from './maintanancesummary.component';

describe('MaintanancesummaryComponent', () => {
  let component: MaintanancesummaryComponent;
  let fixture: ComponentFixture<MaintanancesummaryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MaintanancesummaryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MaintanancesummaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
