import { Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Movie } from 'src/app/models/movie.model';
import { GetMoviesQuery, MovieService } from 'src/app/services/movie.service';
import { RateMovieDialogComponent } from 'src/app/views/rate-movie-dialog/rate-movie-dialog.component';

@Component({
  selector: 'app-movie-card',
  templateUrl: './movie-card.component.html',
  styleUrls: ['./movie-card.component.scss']
})
export class MovieCardComponent implements OnInit {
  @Input() movie: Movie;
  @Input() query: GetMoviesQuery;
  imageSrc: string = 'assets/movie.png';
  isRatedAlready: boolean = false;

  constructor(
    private readonly matDialog: MatDialog,
    private readonly snackBar: MatSnackBar,
    private readonly movieService: MovieService
  ) {}

  ngOnInit(): void {
    this.isRatedAlready = this.movieService.findRatingHistory(this.movie.movieID);

    if (this.movie.imageName) {
      this.imageSrc = `assets/images/${this.movie.imageName}`;
    }
  }

  onRate(): void {
    this.matDialog.open(RateMovieDialogComponent, {
      data: {
        id: this.movie.movieID,
        title: this.movie.title
      }
    })
      .afterClosed()
      .subscribe((message: string) => {
        if (message) {
          this.snackBar.open(message);
          this.movieService.getMovies(this.query);
        }
      });
  }
}
