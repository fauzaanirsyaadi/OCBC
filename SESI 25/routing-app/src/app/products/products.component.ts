import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  products = [
    {
      id: "1",
      name: 'satu',
      description: "product satu"
    },
    {
      id: "2",
      name: 'dua',
      description: "product dua"
    },
    {
      id: "3",
      name: 'tiga',
      description: "product tiga"
    },
  ]
  constructor() { }

  ngOnInit(): void {
  }

}
