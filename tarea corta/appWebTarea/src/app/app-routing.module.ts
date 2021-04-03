import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {LadminComponent} from './ladmin/ladmin.component'
import {MainComponent} from './main/main.component'
import {AdContentComponent} from './ad-content/ad-content.component'
import {LchefComponent} from './lchef/lchef.component'
import {ChContentComponent} from './ch-content/ch-content.component'


const routes: Routes = [
  { path: 'admin', component: LadminComponent },
  { path: '', component: MainComponent },
  { path: 'adcontent', component: AdContentComponent },
  { path: 'chef', component: LchefComponent},
  { path: 'chcontent', component: ChContentComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
  public show:boolean = false;
 

  ngOnInit () {  }

  toggle() {
    this.show = !this.show;
  }

 }
