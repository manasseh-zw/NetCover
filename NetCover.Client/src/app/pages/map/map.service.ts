import { Injectable } from '@angular/core';
import { CellTower } from './types/CellTower';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MapService {

  apiUrl: string = "http://localhost:5280/api/CellTowers/";

  constructor(private http: HttpClient) {
  }

  GetCellTowers = (): Observable<CellTower[]> => {
    var response = this.http.get<CellTower[]>(this.apiUrl);
    return response;
  }
}
