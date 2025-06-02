import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { WEB_API_URL } from "../app.constants";
import { map, Observable, throwError } from 'rxjs';
import { Paitent } from '../models/paitent.model';
import { ApiResponse } from '../models/api-repsonse.model';

@Injectable({
  providedIn: 'root'
})
export class PatientsService {
  private pmsUrl = `${WEB_API_URL}api/v1/`;
  constructor(private http: HttpClient) { }

  getAllPatients(): Observable<Paitent[]> {
    const url = `${this.pmsUrl}paitents`;
    return this.http.get<ApiResponse<Paitent[]>>(url)
      .pipe(map(result => {
        if (result.success)
          return result.data;
        throw new Error(result.error);
      }));
  }

  addPatient(paitent: Paitent): Observable<boolean> {
    const url = `${this.pmsUrl}paitents`;
    return this.http.post<ApiResponse<Paitent>>(url, paitent)
      .pipe(map(reslut => {
        if(reslut.success)
          return true;
        return false;
      }));
  }
}
