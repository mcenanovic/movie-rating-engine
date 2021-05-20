import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-movie-card',
  templateUrl: './movie-card.component.html',
  styleUrls: ['./movie-card.component.scss']
})
export class MovieCardComponent implements OnInit {
  title: string = 'Movie ABC';
  description: string = 'This is a description of a movie';
  releaseDate: string = '12/12/2012';
  casts: string[] = [
    'Actor 1',
    'Actor 2'
  ];

  rating: number = 3.5;
  
  constructor() { }

  ngOnInit(): void {
  }

}
