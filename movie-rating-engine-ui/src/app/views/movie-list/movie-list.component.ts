import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.scss']
})
export class MovieListComponent implements OnInit {
  searchInput: string = '';
  category: string = 'movie';

  onSearchChange(): void {}

  constructor() { }

  ngOnInit(): void {
  }

}
