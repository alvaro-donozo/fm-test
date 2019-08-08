import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  private serviceUrl = environment.serverUrl;
  private darkSkyUrl = 'https://cors-anywhere.herokuapp.com/https://api.darksky.net/forecast/';
  private darkSkyKey = environment.darkSkyKey;

  constructor(private httpService: HttpClient) { }

  public getFromService<T>(resource: string): Observable<T> {
    return this.httpService.get<T>(this.serviceUrl + resource);
  }

  public getFromDarkSky<T>(latitude: string, longitude: string, time: string): Observable<T> {
    const baseUrl = this.darkSkyUrl + this.darkSkyKey + '/';
    const cityData = `${latitude},${longitude},${time}`;
    return this.httpService.get<T>(baseUrl + cityData);
  }
}
