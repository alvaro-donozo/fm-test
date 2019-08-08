import { Injectable } from '@angular/core';
import { HttpService } from '../../core/services/http.service';
import { Observable } from 'rxjs';

import { City } from '../../core/models/city';

@Injectable({
  providedIn: 'root'
})
export class CitiesService {
  private resource = 'cities';

  constructor(private httpService: HttpService) { }

  public getCities(): Observable<City[]> {
    return this.httpService.getFromService(this.resource);
  }

  public getForecast(city: City): Observable<any> {
    const latitude = String(city.latitude);
    const longitude = String(city.longitude);
    const time = '2019-07-04T12:00:00';
    return this.httpService.getFromDarkSky(latitude, longitude, time);
  }
}
