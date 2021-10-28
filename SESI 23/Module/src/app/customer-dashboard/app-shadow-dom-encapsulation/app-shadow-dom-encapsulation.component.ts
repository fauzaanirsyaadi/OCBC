import {Component, ViewEncapsulation} from '@angular/core';

@Component({
  selector: 'app-app-shadow-dom-encapsulation',
  // templateUrl: './app-shadow-dom-encapsulation.component.html',
  // styleUrls: ['./app-shadow-dom-encapsulation.component.css']
  template: `
    <h2>ShadowDom</h2>
    <div class="shadow-message">Shadow DOM encapsulation</div>
    <app-app-emulated-encapsulation></app-app-emulated-encapsulation>
    <app-app-no-encapsulation></app-app-no-encapsulation>
  `,
  styles: ['h2, .shadow-message { color: blue; }'],
  encapsulation: ViewEncapsulation.ShadowDom,
})
export class AppShadowDomEncapsulationComponent{
}
