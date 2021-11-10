import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminFoodEditComponent } from './admin-food-edit.component';

describe('AdminFoodEditComponent', () => {
  let component: AdminFoodEditComponent;
  let fixture: ComponentFixture<AdminFoodEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminFoodEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminFoodEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
