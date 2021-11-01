import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-login-reactive-form',
  templateUrl: './login-reactive-form.component.html',
  styleUrls: ['./login-reactive-form.component.css']
})
export class LoginReactiveFormComponent implements OnInit {

  constructor() { }

  isSubmitted = false;

  loginData = new FormGroup({
    username: new FormControl(''),
    password: new FormControl('')
  })

  handleLoginForm () {
    console.log(this.loginData.get('username'))
    console.log(this.loginData.get('password'))
  }

  ngOnInit(): void {
  }

  currentUser:{
    isLogin : boolean,
    username: string,
    password : string
  } = {
    isLogin : false,
    username: '',
    password : '',
  }

  loginForm = new FormGroup({
    username: new FormControl('',[
      Validators.required,
      Validators.minLength(5)
    ]),password: new FormControl('')
  })

  get username() {
    return this.loginForm.get('username')
  }

  // loginForm = new FormGroup ({
  //   username : new FormControl(''),
  //   password : new FormControl('')
  // })
  //
  // onLogin = () {
  //   console.log(this.loginForm);
  //   this.currentUser = {
  //     isLogin: true,
  //     username : this.loginForm.value.username,
  //     password : this.loginForm.value.password
  //   }
  // }

}
