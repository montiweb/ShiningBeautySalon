import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-panel-form',
  templateUrl: './panel-form.component.html',
  styleUrls: ['./panel-form.component.css']
})
export class PanelFormComponent implements OnInit {

  panelAuthenticate: number;

  constructor(
    private router: Router,
    private route: ActivatedRoute) { }

  ngOnInit(): void {

    this.panelAuthenticate = parseInt(this.route.snapshot.params['panelAuthenticate']);

    if (this.panelAuthenticate === 0) {
      this.router.navigate(['/login']);
    }
    else {
      this.router.navigate(['/panel/1']);
    }
  }

}
