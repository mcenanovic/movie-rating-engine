import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { MatSnackBar } from "@angular/material/snack-bar";
import { BehaviorSubject, Observable } from "rxjs";
import { finalize } from "rxjs/operators";
import { Movie } from "src/app/models/movie.model";
import { environment } from "src/environments/environment";

const LOCAL_STORAGE_DATA_KEY = 'movieRatingEngineData';

@Injectable({ providedIn: 'root' })
export class MovieService {
  private readonly _apiUrl = `${environment.apiUrl}api/movies`;
  private _movies = new BehaviorSubject<Movie[]>([]);
  private _isLoading = new BehaviorSubject<boolean>(false);

  get movies$() {
    return this._movies.asObservable();
  }

  get isLoading$() {
    return this._isLoading.asObservable();
  }

  constructor(
    private readonly http: HttpClient,
    private readonly snackBar: MatSnackBar
  ) {}
  
  getMovies(query?: GetMoviesQuery): void {
    this._isLoading.next(true);

    this.http
      .get<Movie[]>(this._apiUrl, { params: {
        isMovie: query.isMovie ? 'true' : 'false',
        search: query.search,
        count: query.count.toString()
      }})
      .pipe(
        finalize(() => this._isLoading.next(false))
      )
      .subscribe(
        (result: Movie[]) => {
          this._movies.next(result);
        },
        () => this.snackBar.open('An error occurred while retrieving movies')
      );
  }

  findRatingHistory(movieID: number): boolean {
    const localData = JSON.parse(localStorage.getItem(LOCAL_STORAGE_DATA_KEY)) || [];

    return localData.some(x => x.id === movieID);
  }

  rateMovie(movieID: number, rating: number): Observable<Movie> {
    const localData = JSON.parse(localStorage.getItem(LOCAL_STORAGE_DATA_KEY)) || [];
    localData.push({
      id: movieID,
      rating: rating
    });
    localStorage.setItem(LOCAL_STORAGE_DATA_KEY, JSON.stringify(localData));

    return this.http.put<Movie>(this._apiUrl + `/${movieID}`, rating);
  }
}

export interface GetMoviesQuery {
  isMovie?: boolean;
  search?: string;
  count?: number;
}