import {Component, ViewEncapsulation} from '@angular/core';

@Component({
  selector: 'app-app-no-encapsulation',
  // templateUrl: './app-no-encapsulation.component.html',
  // styleUrls: ['./app-no-encapsulation.component.css']
  template: `
    <h2>None</h2>
    <div class="none-message">No encapsulation</div>
  `,
  styles: ['h2, .none-message { color: red; }'],
  encapsulation: ViewEncapsulation.None,
})
export class AppNoEncapsulationComponent  { }
