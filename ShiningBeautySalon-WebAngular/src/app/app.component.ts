import { Component } from '@angular/core';
import { SalonService } from './salon.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ShiningBeautySalon-WebAngular';
  salonList: any[] = [];

  constructor(private salonService: SalonService) { }

  ngOnInit() {

  /*-------------------------------------------------------------------------------------------------------------------*/
  /*----| Call Salon Service To Get Salon List |-----------------------------------------------------------------------*/
  /*-------------------------------------------------------------------------------------------------------------------*/
    this.salonService.get().subscribe(
      (data: any[]) => {
        this.salonList = data;
      },
      error => {}
    )
  /*-------------------------------------------------------------------------------------------------------------------*/
  /*-------------------------------------------------------------------------------------------------------------------*/

  }
}
