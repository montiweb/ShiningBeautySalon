import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-panel-form',
  templateUrl: './panel-form.component.html',
  styleUrls: ['./panel-form.component.css']
})
export class PanelFormComponent implements OnInit {

  panelAuthenticate = false;

  constructor(private router: Router) { }

  ngOnInit(): void {
    //if (!this.panelAuthenticate) {
    //  this.router.navigate(['/login']);
    //}
  }

}
