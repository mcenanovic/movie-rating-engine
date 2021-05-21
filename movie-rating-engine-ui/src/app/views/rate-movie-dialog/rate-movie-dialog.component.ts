import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { finalize } from 'rxjs/operators';
import { MovieService } from 'src/app/services/movie.service';

@Component({
  selector: 'app-rate-movie-dialog',
  templateUrl: './rate-movie-dialog.component.html',
  styleUrls: ['./rate-movie-dialog.component.scss']
})
export class RateMovieDialogComponent {
  isLoading: boolean = false;
  rating: number = 0;

  constructor(
    private readonly dialogRef: MatDialogRef<RateMovieDialogComponent>,
    private readonly snackBar: MatSnackBar,
    public readonly movieService: MovieService,
    @Inject(MAT_DIALOG_DATA) public readonly data: { id: number, title: string }
  ) { }

  onRate(): void {
    if (this.rating === 0) {
      this.snackBar.open('Please rate the movie');
      return;
    }

    let message: string = '';
    
    this.isLoading = true;
    this.movieService.rateMovie(this.data.id, this.rating)
    .pipe(
      finalize(() => {
        this.isLoading = false;
        this.dialogRef.close(message);
      })
    )
    .subscribe(
      () => message = 'Movie rated successfully',
      () => message = 'An error occurred while rating movie'
    );
  }

  onCancel(): void {
    this.dialogRef.close();
  }

}
