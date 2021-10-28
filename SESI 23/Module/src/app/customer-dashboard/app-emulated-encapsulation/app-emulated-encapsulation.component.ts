import {Component, ViewEncapsulation} from '@angular/core';

@Component({
  selector: 'app-app-emulated-encapsulation',
  // templateUrl: './app-emulated-encapsulation.component.html',
  // styleUrls: ['./app-emulated-encapsulation.component.css']
  template: `
    <h2>Emulated</h2>
    <div class="emulated-message">Emulated encapsulation</div>
    <app-app-no-encapsulation></app-app-no-encapsulation>
  `,
  styles: ['h2, .emulated-message { color: green; }'],
  encapsulation: ViewEncapsulation.Emulated,
})
export class AppEmulatedEncapsulationComponent {

}
