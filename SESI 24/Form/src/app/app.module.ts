import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';

import { TemplateDrivenFormComponent } from './template-driven-form/template-driven-form.component';
import { LoginReactiveFormComponent } from './login-reactive-form/login-reactive-form.component';
//hero
import { CommonModule } from '@angular/common';
import { HeroFormComponent } from './hero-form/hero-form.component';

@NgModule({
  declarations: [
    AppComponent,
    //hero
    HeroFormComponent,
    TemplateDrivenFormComponent,
    LoginReactiveFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    //  hero
    CommonModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
