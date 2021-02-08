import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { PanelLayoutComponent } from './layout-panel/panel-layout/panel-layout.component';
import { MainLayoutComponent } from './layout-main/main-layout/main-layout.component';



@NgModule({
  declarations: [
    PanelLayoutComponent,
    MainLayoutComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ]
})
export class LayoutModule { }
