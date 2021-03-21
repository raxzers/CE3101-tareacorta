import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {LadminComponent} from './ladmin/ladmin.component'
import {MainComponent} from './main/main.component'
import {AdContentComponent} from './ad-content/ad-content.component'

const routes: Routes = [
  { path: 'admin', component: LadminComponent },
  { path: '', component: MainComponent },
  { path: 'adcontent', component: AdContentComponent }
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
