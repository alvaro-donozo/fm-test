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

  constructor(private service: CitiesService) { }

  ngOnInit() {
    this.cities = this.service.getCities();
  }

}
