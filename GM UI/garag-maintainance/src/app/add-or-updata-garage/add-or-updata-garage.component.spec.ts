import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddOrUpdataGarageComponent } from './add-or-updata-garage.component';

describe('AddOrUpdataGarageComponent', () => {
  let component: AddOrUpdataGarageComponent;
  let fixture: ComponentFixture<AddOrUpdataGarageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddOrUpdataGarageComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddOrUpdataGarageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
