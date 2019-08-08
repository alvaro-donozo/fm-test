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
    return this.httpService.get(this.resource);
  }
}
