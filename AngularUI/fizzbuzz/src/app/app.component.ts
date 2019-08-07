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
  error$: Observable<string>;

  private firstValue$ = new Subject<Number>();
  private secondValue$ = new Subject<Number>();

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
        return this.apiService.getMulti(a, b);
      }),
      map(x => x.result)
    );
  }

  calculateFizzBuzz(one: string, two: string) {
    if (this.checkValue(one) && this.checkValue(two) && this.checkValueOneBiggerTwo(one, two)) {
      this.firstValue$.next(Number(one));
      this.secondValue$.next(Number(two));
    }
  }

  checkValueOneBiggerTwo(one: string, two: string): boolean {
    const num1 = Number(one);
    const num2 = Number(two);

    if (num1 >= num2) {
      this.error$ = of('From value must be smaller than Until value.');
      return false;
    }
    return true;
  }

  checkValue(value: string): boolean {
      if (!value) {
        this.error$ = of('Value must be provided');
        return false;
      }
      const num = Number(value);
      if (!(num)) {
        this.error$ = of('Value must be a number bigger than 1.');
        return false;
      }

      if (num < 1) {
        this.error$ = of('Value must not be bigger than 1.');
        return false;
      }

      if (num > 100) {
        this.error$ = of('Value must not be smaller than 100.');
        return false;
      }
      this.error$ = of(undefined);
      return true;
  }
}
