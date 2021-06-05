import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';

import { environment } from 'src/environments/environment';
import { IBookDto } from '../interfaces/ibook-dto';

const baseUrl = environment.functionApiUrl;

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(private httpClient: HttpClient) {
  }

  // GET All Books
  GetAllBooks(): Observable<IBookDto[]> {

    console.log(`Get All Books request received.`);

    return this.httpClient
      .get<IBookDto[]>(`${baseUrl}/GetAllBooks`)
      .pipe(retry(1), catchError(this.errorHandler));
  }

  // Error handling
  errorHandler(error: any) {

    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  }

}
