import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { Todo } from '../../models/Todo';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {

  todos:Todo[] = [];
  inputTodo: string = '';
  @Output() newTodoEvent = new EventEmitter<Todo>();

  constructor() { }

  ngOnInit(): void {
    this.todos=[
      {
        content:'First todo',
        completed : false
      },
      {
        content : 'Second todo',
        completed : false
      }
    ];
  }

  toggleDone (id:number){
    this.todos.map((v,i) =>{
      if (i==id) v.completed = !v.completed;
      console.log(v);
      return v;
    })
  }

  deleteTodo (id:number){
    this.todos = this.todos.filter((v,i) => i !== id);
  }

  editSaveTodo(todo: Todo) {
    if (todo.content != '') {
      todo.content = this.inputTodo;
      todo.completed = false;
      this.inputTodo = '';
    } else {
      console.log('data tidak boleh kosong')
    }
  }

  addTodo(todo:Todo){
    this.todos.push(todo);
  }

  updateTodo(todo: Todo){
    const Todo = {
      content : this.inputTodo,
      completed : false
    };

    if (this.inputTodo != '') {
      this.newTodoEvent.emit(Todo);
    }else{
      this.inputTodo = '';
      console.log('tidak boleh kosong')
    }
  }

}
