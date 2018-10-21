import { Vehicle } from './../models/vehicle';
import { VehicleService } from '../services/vehicle.service';
import { Component, OnInit, ViewContainerRef } from '@angular/core';
import { ToastsManager } from 'ng2-toastr/ng2-toastr';
import { ActivatedRoute, Router } from '@angular/router';
import { SaveVehicle } from '../models/vehicle';



@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  makes: any[];
  models: any[];
  features: any[];
  vehicle: SaveVehicle = {
    id: 0,
    makeid: 0,
    modelid: 0,
    is_registered: false,
    features: [],
    contact: {
      name: '',
      phone: '',
      email: ''
    }
  };
  // vehicle: any = {
  //   features: [],
  //   contact: {}
  // };


  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private vehicleService: VehicleService,
    private toastr: ToastsManager,
    vcr: ViewContainerRef) {

      this.toastr.setRootViewContainerRef(vcr);

      route.params.subscribe(p => {
        if (p) {
        this.vehicle.id = +p['id'];
        }
      });
    }

  ngOnInit() {


    this.vehicleService.getMakes()
    .subscribe((makes: any[]) => {
      this.makes = makes;

      this.vehicleService.getFeatures()
      .subscribe((features: any[]) => {
        this.features = features;
      });

      if (this.vehicle.id) {
        this.vehicleService.getVehicle(this.vehicle.id)
        .subscribe((v: any) => {
          if (this.vehicle.id) {
            this.setVehicle(v);
            this.populateModels();
          }
        });
      }
    });


  }

  private setVehicle(v: Vehicle) {
    this.vehicle.id = v.id;
    this.vehicle.makeid = v.make.id;
    this.vehicle.modelid = v.model.id;
    this.vehicle.is_registered = v.is_registered;
    this.vehicle.contact = v.contact;

  }

  onMakeChange() {
    this.populateModels();
    delete this.vehicle.modelid;
  }

  private populateModels() {
        // tslint:disable-next-line:triple-equals
        const selectedMake = this.makes.find(m => m.id == this.vehicle.makeid);
        this.models = selectedMake ? selectedMake.models : [];
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
    if (this.vehicle.id) {
    console.log(this.vehicle.id);
    }
    if (this.vehicle.id) {
      this.vehicleService.update(this.vehicle)
      .subscribe( x => {
        this.toastr.success('Success', 'The vehicle was updated');
      });
    } else {
    this.vehicle.id = 0;
    this.vehicleService.create(this.vehicle)
    .subscribe(
      x => console.log(x),
      err => {
        this.toastr.error('An unexpected error has ocurred!', 'Error!');
      });
    }
  }

  delete() {
    if (confirm('Are you sure?')) {
      this.vehicleService.delete(this.vehicle.id)
      .subscribe( x => {
        this.router.navigate(['/']);
      });
    }
  }

}
