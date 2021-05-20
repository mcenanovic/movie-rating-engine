import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { BehaviorSubject, Observable } from "rxjs";
import { Movie } from "src/app/models/movie.model";
import { environment } from "src/environments/environment";

@Injectable({ providedIn: 'root' })
export class MovieService {
  private readonly _apiUrl = `${environment.apiUrl}api/movies`;
  private _movies = new BehaviorSubject<Movie[]>(null);

  constructor(
    private http: HttpClient
  ) {}
  
  getMovies(query?: GetMoviesQuery): void {
    let params = new HttpParams();
    params.append('isMovie', query.isMovie ? 'true' : 'false');
    params.append('search', query.search);
    params.append('count', query.count.toString())
    this.http
      .get<Movie[]>(this._apiUrl, { params })
      .subscribe(result => {
        this._movies.next(result);
      });
  }
}

export interface GetMoviesQuery {
  isMovie?: boolean;
  search?: string;
  count?: number;
}