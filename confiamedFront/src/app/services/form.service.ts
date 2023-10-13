import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { FormAndDetail, FormDetail } from 'src/interface/FormDetail';

@Injectable({
  providedIn: 'root'
})
export class FormService {

  Url = environment.urlBase

  constructor(
    private http:HttpClient
  ) {

   }

   get():Observable<FormAndDetail[]>{
    let endPoint = this.Url + `Form`

    return this.http.get<FormAndDetail[]>(endPoint)

   }
}
