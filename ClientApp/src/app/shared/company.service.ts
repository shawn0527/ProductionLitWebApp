import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Url } from './url';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  constructor(private http: HttpClient) { }

  getCompanies(): Observable<any> {
    return this.http.get(Url.serverSideBaseUrl + '/api/companies')
  }
}
