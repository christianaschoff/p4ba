import { Component, Input, OnInit } from '@angular/core';
import { Observable, Subject, of, combineLatest } from 'rxjs';
import { ApiService } from './api.service';
import { distinctUntilChanged, switchMap, map } from 'rxjs/operators';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  single$: Observable<string>;
  lst$: Observable<string[]>;

  private firstValue$ = new Subject<string>();
  private secondValue$ = new Subject<string>();

  constructor(private readonly apiService: ApiService) {
  }

  ngOnInit(): void {
   /* this.single$ = this.firstValue$.pipe(
      distinctUntilChanged(),
      switchMap(val => {
        if (!val) { return of({result: []}); }
        return this.apiService.getOne(val);
      }),
      map(x => x.result[0])
    );
*/
    this.lst$ = combineLatest(this.firstValue$, this.secondValue$).pipe(
      distinctUntilChanged(),
      switchMap(([a, b]) => {
        if (!a || !b) { return of({result: []}); }
        return this.apiService.getMulti(Number(a), Number(b));
      }),
      map(x => x.result)
    );
  }

  checkOneValue(one: string, two: string) {
    this.firstValue$.next(one);
    this.secondValue$.next(two);
  }

}
