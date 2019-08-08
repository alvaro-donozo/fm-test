import { Component, OnInit } from '@angular/core';
import { CitiesService } from './services/cities.service';
import { City } from '../core/models/city';
import { Observable } from 'rxjs';

@Component({
  selector: 'fm-systems-cities',
  templateUrl: './cities.component.html',
  styleUrls: ['./cities.component.scss']
})
export class CitiesComponent implements OnInit {
  cities: Observable<City[]>;
  forecast: Observable<any>;

  constructor(private service: CitiesService) { }

  ngOnInit() {
    this.cities = this.service.getCities();
  }

  public getForecast(event: any): void {
    const city = event.target.value;
    this.forecast = this.service.getForecast(city);
  }
}
