import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerDashboardComponent } from './customer-dashboard/customer-dashboard.component';
import { AppNoEncapsulationComponent } from './app-no-encapsulation/app-no-encapsulation.component';
import { AppEmulatedEncapsulationComponent } from './app-emulated-encapsulation/app-emulated-encapsulation.component';
import { AppShadowDomEncapsulationComponent } from './app-shadow-dom-encapsulation/app-shadow-dom-encapsulation.component';



@NgModule({
  declarations: [
    CustomerDashboardComponent,
    AppNoEncapsulationComponent,
    AppEmulatedEncapsulationComponent,
    AppShadowDomEncapsulationComponent
  ],
  exports: [
    AppNoEncapsulationComponent,
    AppEmulatedEncapsulationComponent,
    AppShadowDomEncapsulationComponent
  ],
  imports: [
    CommonModule
  ]
})
export class CustomerDashboardModule { }
