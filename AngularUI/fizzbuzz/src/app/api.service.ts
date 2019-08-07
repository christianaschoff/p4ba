import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError, map, tap } from 'rxjs/operators';
import { FizzBuzzResponse } from './FizzBuzzResponse';
import { FizzBuzzRequest } from './FizzBuzzRequest';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
    apiUrl = 'http://localhost:5000/Api/FizzBuzz';
    constructor(private http: HttpClient) { }

    httpOptions = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json'
        })
      };

    getOne(num: string): Observable<FizzBuzzResponse> {
        return this.http.get<FizzBuzzResponse>(this.apiUrl + '/' + num, this.httpOptions)
        .pipe(
        retry(1),
        catchError(this.handleError));
    }

    getMulti(from: Number, to: Number): Observable<FizzBuzzResponse> {
         const request: FizzBuzzRequest = {From: from, Until: to};
        return this.http.post<FizzBuzzResponse>(this.apiUrl + '/', JSON.stringify(request), this.httpOptions)
        .pipe(
        retry(1),
        catchError(this.handleError));
    }

    handleError(error) {
        let errorMessage = '';
        if (error.error instanceof ErrorEvent) {
          // Get client-side error
          errorMessage = error.error.message;
        } else {
          // Get server-side error
          errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
        }
        window.alert(errorMessage);
        return throwError(errorMessage);
     }
}
