import { Component, OnInit } from '@angular/core';
import { CitiesService } from './services/cities.service';
import { City } from '../core/models/city';

@Component({
  selector: 'fm-systems-cities',
  templateUrl: './cities.component.html',
  styleUrls: ['./cities.component.scss']
})
export class CitiesComponent implements OnInit {
  cities: City[];
  forecast: any;

  constructor(private service: CitiesService) { }

  ngOnInit() {
    this.service.getCities()
      .subscribe(cities => this.cities = cities);
  }

  public getForecast(event: any): void {
    const cityId = event.target.value;
    const city = this.cities.find(cityFound => cityFound.id === cityId);
    this.service.getForecast(city)
      .subscribe(data => this.forecast = data);
  }
}
