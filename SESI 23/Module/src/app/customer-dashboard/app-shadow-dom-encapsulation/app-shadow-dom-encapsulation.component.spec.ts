import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppShadowDomEncapsulationComponent } from './app-shadow-dom-encapsulation.component';

describe('AppShadowDomEncapsulationComponent', () => {
  let component: AppShadowDomEncapsulationComponent;
  let fixture: ComponentFixture<AppShadowDomEncapsulationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppShadowDomEncapsulationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppShadowDomEncapsulationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
