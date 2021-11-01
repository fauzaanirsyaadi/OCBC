import { Injectable } from '@angular/core';
import {HttpClient, HttpErrorResponse} from "@angular/common/http";
import {Observable, throwError} from "rxjs";
import {User} from "../user";
import {catchError} from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  endpoint: string = 'http://localhost:4000/api';
  constructor(
    private http: HttpClient){}
  //sign-up
  signUp(user: User): Observable<any>{
    let api = '${this.endpoint}/register-user';
    return this.http
      .post(api, user)
      .pipe(
        catchError(this.handleError))
  }

  //Error Handling
  handleError(error: HttpErrorResponse){
    let msg = '';
    if (error.error instanceof ErrorEvent){
      msg = error.error.message;
    }else{
      msg = 'Error Code: ${error.status}\nMessage:${error.message}';
    }
    return throwError(msg)
  }
}
