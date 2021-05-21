import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subject, Subscription } from 'rxjs';
import { debounceTime, distinctUntilChanged } from 'rxjs/operators';
import { Movie } from 'src/app/models/movie.model';
import { GetMoviesQuery, MovieService } from 'src/app/services/movie.service';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.scss']
})
export class MovieListComponent implements OnInit, OnDestroy {
  movies: Movie[] = [];
  subscription: Subscription;
  searchChanged: Subject<string> = new Subject<string>();

  query: GetMoviesQuery = {
    isMovie: true,
    search: '',
    count: 10,
  }

  constructor(
    public readonly movieService: MovieService
  ) { }

  ngOnInit(): void {
    this.movieService.getMovies(this.query);

    this.subscription = this.movieService.movies$
      .subscribe((movies: Movie[]) => {
        this.movies = movies;
      });

    this.searchChanged
      .pipe(
        debounceTime(1000),
        distinctUntilChanged()
      )
      .subscribe((search: string) => {
        this.query.search = search;

        if (search.length != 1) {
          this.movieService.getMovies(this.query);
        }
      });
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  onSearchChanged(text: string) {
    this.searchChanged.next(text);
  }

  onCategoryChange(): void {
    this.query.count = 10;
    this.movieService.getMovies(this.query);
  }

  onViewMoreResults(): void {
    this.query.count += 10;
    this.movieService.getMovies(this.query);
  }

}
