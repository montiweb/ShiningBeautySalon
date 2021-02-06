import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { SalonService } from './salon.service';
import { LayoutModule } from './layout/layout.module';
import { LoginModule } from './modules/login/login.module';
import { PanelModule } from './modules/panel/panel.module';
import { HomeModule } from './modules/home/home.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    LayoutModule,
    LoginModule,
    PanelModule,
    HomeModule
  ],
  providers: [
    SalonService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
