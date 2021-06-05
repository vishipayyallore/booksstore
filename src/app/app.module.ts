import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TopNavbarComponent } from './components/shared/top-navbar/top-navbar.component';
import { FooterComponent } from './components/shared/footer/footer.component';
import { PageNotfoundComponent } from './components/shared/page-notfound/page-notfound.component';
import { DashboardComponent } from './components/home/dashboard/dashboard.component';
import { BookslistComponent } from './components/books/bookslist/bookslist.component';

@NgModule({
  declarations: [
    AppComponent,
    TopNavbarComponent,
    FooterComponent,
    PageNotfoundComponent,
    DashboardComponent,
    BookslistComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
