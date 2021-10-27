import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  // title = 'my-app';
  parentMessage = "Halo ini dari Parent"
  items = ['sepatu', 'sendal', 'tas']
  addItemInParent(newItem: string){
    this.items.push(newItem);
  }

  // currentCustomer = 'Maria';
  // title = 'Featured product: ';
  // itemImageUrl = '../assets/potted-plant.png';
}
