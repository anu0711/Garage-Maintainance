import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VechicalComponent } from './vechical.component';

describe('VechicalComponent', () => {
  let component: VechicalComponent;
  let fixture: ComponentFixture<VechicalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VechicalComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VechicalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
