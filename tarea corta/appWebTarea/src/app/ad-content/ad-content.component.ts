import { Component, OnInit } from '@angular/core';
import { from } from 'rxjs';
import {HttpClient} from '@angular/common/http';
import { pipe } from 'rxjs';
import { map } from 'rxjs/operators';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';

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
  public modificarPlatillo:boolean = false;
  public modificadorPlatillo:boolean = false;

  closeResult = '';
 modP=null;
  public patillo:plato =

    {
      Name:"",
      price: null,
      calorie: null,
      description:""
     

    };
    t2=null;t3=null;
  constructor(private http:HttpClient,private modalService: NgbModal) {}

  ngOnInit(): void {  }
 

  get( url: string){
    this.t2=null;
    this.http.get(url).subscribe((data)=>{
      
    
    console.log(data);
     
    this.t2= data;
  })
      
  }

//s
//http://localhost:5000/api/clientes
  toggleMenu() {
    this.get("https://jsonplaceholder.typicode.com/posts");
    this.showMenu = !this.showMenu;
    this.showtop10 = false;
    this.crearPlatillos=false;
    this.modificarPlatillo=false;
  }

  toggleTop10() {
    this.get('https://jsonplaceholder.typicode.com/todos/1');
    this.showtop10 = !this.showtop10;
  this.showMenu=false;
  this.crearPlatillos=false;
  this.modificarPlatillo=false;}

  toggleCrearP() {
   
    this.crearPlatillos = !this.crearPlatillos;
    this.showtop10 = false;
  this.showMenu=false;
  this.modificarPlatillo=false;
}

  postPlatillo():void{

    console.log("{Name:"+this.patillo.Name+",price:"+ this.patillo.price+ ",Calorie:"+this.patillo.calorie+",description:"+this.patillo.description+ "}") ;
    //this.http.post('http://ptsv2.com/t/de1nj-1616448969', { title: 'Angular POST Request Example' }).subscribe(data => {
     // console.log(data) ;
       // })
  }
  toggleModificar() {
    this.get("https://jsonplaceholder.typicode.com/posts");
    this.modificarPlatillo = !this.modificarPlatillo;
    this.showtop10 = false;
    this.crearPlatillos=false;
    this.showMenu=false;
  }


  open(content, index) {

    this.modP= this.t2[index-1];
    //alert(mosd.title);
    

    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }
  
}
