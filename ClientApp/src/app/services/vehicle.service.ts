import { SaveVehicle } from './../models/vehicle';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';


@Injectable()
export class VehicleService {

  constructor(private http: HttpClient) { }

  getMakes() {
    return this.http.get('/api/makes');
  }

  getFeatures() {
    return this.http.get('/api/features');
  }

  create(vehicle) {
    return this.http.post('/api/vehicles', vehicle)
    .pipe(map((response: any) => response.json()));
  }


  getVehicle(id) {
    return this.http.get('/api/vehicles/' + id);
  }

  update(vehicle: SaveVehicle) {
    return this.http.put('/api/vehicles/' + vehicle.id, vehicle)
    .pipe(map((response: any) => response.json()));
  }

  delete(id) {
    return this.http.delete('/api/vehicles/' + id);
  }
}
