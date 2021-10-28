import { Component } from '@angular/core';
import { Task } from '../Task';
import {NgForm} from "@angular/forms";

@Component({
  selector: 'app-template-driven-form',
  templateUrl: './template-driven-form.component.html',
  styleUrls: ['./template-driven-form.component.css']
})
export class TemplateDrivenFormComponent {

  categories: string[] = [
    'School',
    'Work',
    'Hobby'
  ];
  private form: any;

  tasks : Task[] = []

  handleFormOnSubmit  (from: NgForm) {
    const { taskName, category } = this.form.value
    this.tasks = [...this.tasks, new Task(taskName, false, category)]
    this.form.reset()
  }

}
