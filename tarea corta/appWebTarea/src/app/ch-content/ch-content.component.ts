import { Component, OnInit } from '@angular/core';
import { from } from 'rxjs';
import {HttpClient} from '@angular/common/http';
import { pipe } from 'rxjs';
import { map } from 'rxjs/operators';

interface plato{
  Name: string;
  price: Number;
  calorie: Number;
  description:String;
}
@Component({
  selector: 'app-ch-content',
  templateUrl: './ch-content.component.html',
  styleUrls: ['./ch-content.component.css']
})
export class ChContentComponent implements OnInit {
  public showPedidos:boolean = false;
  public showMisPedidos:boolean = false;

  constructor() { }

  ngOnInit(): void {
  }
  t2=null;

  togglePedidos() {
    //this.get("https://jsonplaceholder.typicode.com/posts");
    this.showPedidos = !this.showPedidos;
    this.showMisPedidos=false;
  }
  toggleMisPedidos() {
    //this.get("https://jsonplaceholder.typicode.com/posts");
    this.showMisPedidos=!this.showMisPedidos;
    this.showPedidos = false;

  }


}
