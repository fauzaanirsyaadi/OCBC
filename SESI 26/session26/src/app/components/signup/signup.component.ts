import { Component, OnInit } from '@angular/core';
import {AuthService} from "../../shared/auth.service";
import {Router} from "@angular/router";
import {FormControl, FormGroup, Validators} from "@angular/forms";

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  constructor(public authService: AuthService, public router:Router) { }

  // private _signupForm = new FormGroup({
  signupForm = new FormGroup({
    name : new FormControl('',[Validators.required, Validators.minLength(5)]),
    password: new FormControl('',[Validators.required, Validators.maxLength(5)]),
    email: new FormControl('', [Validators.required, Validators.email])
  });

  // get signupForm(): FormGroup {
  //   return this._signupForm;
  // }
  get name(){
    return this.signupForm.get('name')
  }

  get password(){
    return this.signupForm.get('password')
  }

  get email(){
    return this.signupForm.get('email')
  }

  ngOnInit(): void {
  }

  registerUser(){
    this.authService.signUp(this.signupForm.value).subscribe((res)=>
    {
    if(res.result) {
      this.signupForm.reset()
      this.router.navigate(['/login']);
      }
    })
  }
}
