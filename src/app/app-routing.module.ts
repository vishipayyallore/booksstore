import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BookslistComponent } from './components/books/bookslist/bookslist.component';
import { DashboardComponent } from './components/home/dashboard/dashboard.component';
import { PageNotfoundComponent } from './components/shared/page-notfound/page-notfound.component';

const routes: Routes = [
  { path: 'dashboard', component: DashboardComponent },
  { path: 'books', component: BookslistComponent },
  { path: 'pagenotfound', component: PageNotfoundComponent },
  { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
  { path: '**', redirectTo: 'pagenotfound', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
