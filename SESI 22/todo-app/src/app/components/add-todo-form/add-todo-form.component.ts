import { Component, EventEmitter, Output } from '@angular/core';
import { Todo } from '../../models/Todo';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-todo-form',
  templateUrl: './add-todo-form.component.html',
  styleUrls: ['./add-todo-form.component.css']
})
export class AddTodoFormComponent {

  @Output() newTodoEvent = new EventEmitter<Todo>();

  inputTodo:string = "";

  constructor() {}

  todoData = new FormGroup({
    content: new FormControl('', [Validators.required]),
  });

  addTodo(){
    const todo: Todo = {
      content : this.inputTodo,
      completed : false
    };

    if (this.inputTodo != '') {
      this.newTodoEvent.emit(todo);
    }else{
      this.inputTodo = '';
      console.log('tidak boleh kosong')
    }
    console.log(this.todoData.get('content'))
  }

  get content() {
    return this.todoData.get('content');
  }
}
