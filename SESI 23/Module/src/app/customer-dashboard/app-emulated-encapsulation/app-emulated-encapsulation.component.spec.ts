import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppEmulatedEncapsulationComponent } from './app-emulated-encapsulation.component';

describe('AppEmulatedEncapsulationComponent', () => {
  let component: AppEmulatedEncapsulationComponent;
  let fixture: ComponentFixture<AppEmulatedEncapsulationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppEmulatedEncapsulationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppEmulatedEncapsulationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
