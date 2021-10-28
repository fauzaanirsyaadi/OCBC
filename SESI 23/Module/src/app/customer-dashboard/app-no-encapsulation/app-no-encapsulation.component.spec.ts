import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppNoEncapsulationComponent } from './app-no-encapsulation.component';

describe('AppNoEncapsulationComponent', () => {
  let component: AppNoEncapsulationComponent;
  let fixture: ComponentFixture<AppNoEncapsulationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppNoEncapsulationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppNoEncapsulationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
