import { VehicleService } from '../services/vehicle.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  makes: any[];
  models: any[];
  features: any[];
  vehicle: any = {
    features: [],
    contact: {}
  };

  constructor(private vehicleService: VehicleService
    ) { }

  ngOnInit() {
    this.vehicleService.getMakes()
    .subscribe((makes: any[]) => {
      this.makes = makes;
    });

    this.vehicleService.getFeatures()
    .subscribe((features: any[]) => {
      this.features = features;
    });
  }

  onMakeChange() {
    // tslint:disable-next-line:triple-equals
    const selectedMake = this.makes.find(m => m.id == this.vehicle.makeid);
    this.models = selectedMake ? selectedMake.models : [];
    delete this.vehicle.modelid;
  }

  onFeatureToggle(featureid, $event) {
    if ($event.target.checked) {
      this.vehicle.features.push(featureid);
    } else {
      const index = this.vehicle.features.indexOf(featureid);
      this.vehicle.features.splice(index, 1);
    }
  }

  submit() {
    this.vehicleService.create(this.vehicle)
    .subscribe(x => console.log(x));
  }

}
