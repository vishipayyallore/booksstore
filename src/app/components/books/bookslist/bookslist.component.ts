import { Component, OnInit } from '@angular/core';

import { IBookDto } from 'src/app/interfaces/ibook-dto';
import { BooksService } from 'src/app/services/books.service';

@Component({
  selector: 'app-bookslist',
  templateUrl: './bookslist.component.html',
  styleUrls: ['./bookslist.component.css']
})
export class BookslistComponent implements OnInit {

  // @ts-ignore
  booksList: IBookDto[];

  constructor(private booksService: BooksService) {
  }

  ngOnInit(): void {
    this.retrieveAllBooks();
  }

  retrieveAllBooks() {

    this.booksService.GetAllBooks()
      .subscribe((data: IBookDto[]) => {

        this.booksList = data;
        console.log(this.booksList);
      });
  }

}
