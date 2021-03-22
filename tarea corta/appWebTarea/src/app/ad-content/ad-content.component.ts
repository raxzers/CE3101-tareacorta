import { Component, OnInit } from '@angular/core';
import { from } from 'rxjs';
import {HttpClient} from '@angular/common/http';
import { pipe } from 'rxjs';
import { map } from 'rxjs/operators';


interface Test{
  userId: Number;
  id: Number;
  title: String;
  body:String;
}
interface plato{
  Name: string;
  price: Number;
  calorie: Number;
  description:String;
}
@Component({
  selector: 'app-ad-content',
  templateUrl: './ad-content.component.html',
  styleUrls: ['./ad-content.component.css']
})

export class AdContentComponent implements OnInit {
  public showMenu:boolean = false;
  public showtop10:boolean = false;
  public crearPlatillos:boolean = false;
  public patillo:plato =

    {
      Name:"",
      price: null,
      calorie: null,
      description:""
     

    };
    t2=null;t3=null;
  constructor(private http:HttpClient ) {}

  ngOnInit(): void {
  }
 

  get( url: string){
    this.t2=null;
    this.http.get(url).subscribe((data)=>{
      
    
    console.log(data);
     
    this.t2= data;
  })
      
  }



  toggleMenu() {
    this.get("https://jsonplaceholder.typicode.com/posts");
    this.showMenu = !this.showMenu;
    this.showtop10 = false;
    this.crearPlatillos=false;
  }

  toggleTop10() {
    this.get('https://jsonplaceholder.typicode.com/todos/1');
    this.showtop10 = !this.showtop10;
  this.showMenu=false;
  this.crearPlatillos=false;}

  toggleCrearP() {
   
    this.crearPlatillos = !this.crearPlatillos;
    this.showtop10 = false;
  this.showMenu=false;}

  postPlatillo():void{
    console.log(this.patillo);
    console.log("{Name:"+this.patillo.Name+" price:"+ this.patillo.price+ "}") ;
    //this.http.post('http://ptsv2.com/t/de1nj-1616448969', { title: 'Angular POST Request Example' }).subscribe(data => {
     // console.log(data) ;
       // })
  }
  
}
