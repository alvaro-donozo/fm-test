import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  private serviceUrl = 'http://localhost:8000/api/v1/';

  constructor(private httpService: HttpClient) { }

  public get<T>(resource: string): Observable<T> {
    return this.httpService.get<T>(this.serviceUrl + resource);
  }
}
