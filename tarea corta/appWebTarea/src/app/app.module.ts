import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LadminComponent } from './ladmin/ladmin.component';
import { MainComponent } from './main/main.component';
import { AdContentComponent } from './ad-content/ad-content.component';
import { authInterceptorProviders } from './_helpers/auth.interceptor';
@NgModule({
  declarations: [
    AppComponent,
    LadminComponent,
    MainComponent,
    AdContentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [authInterceptorProviders],
  bootstrap: [AppComponent]
})
export class AppModule { }