import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { XyzComponent } from './xyz/xyz.component';
import { Komponen1Component } from './komponen1/komponen1.component';
import { ButtonComponent } from './button/button.component';
import { AddNewItemComponent } from './add-new-item/add-new-item.component';

@NgModule({
  declarations: [
    AppComponent,
    XyzComponent,
    Komponen1Component,
    ButtonComponent,
    AddNewItemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
