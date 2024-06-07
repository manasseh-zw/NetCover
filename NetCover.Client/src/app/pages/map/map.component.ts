import { AfterViewInit, Component, OnInit, inject } from '@angular/core';
import { DropdownModule } from 'primeng/dropdown';
import * as L from 'leaflet';
import { FormsModule } from '@angular/forms';
import { MapService } from './map.service';
import { CellTower } from './types/CellTower';
import { Network } from './types/Network';
import 'leaflet.markercluster';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-map',
  standalone: true,
  imports: [DropdownModule, FormsModule, CommonModule],
  providers: [],
  templateUrl: './map.component.html',
  styleUrl: './map.component.css'
})


export class MapComponent implements OnInit, AfterViewInit {

  ngOnInit(): void {
    this.mapService.GetCellTowers().subscribe({
      next: (response) => {
        this.cellTowers = response;
        this.filteredCellTowers = response;
        console.log(this.cellTowers);
      },
      error: err => {
        console.log(err);
      }

    })
  }

  ngAfterViewInit(): void {
    this.initializeMap();
    this.addMarkers();
    this.centerMap();


  }

  loading: boolean = false;

  mapService: MapService = inject(MapService);

  cellTowers: CellTower[] = [];

  filteredCellTowers: CellTower[] = [];

  networks = [
    {
      network: Network.Netone,
      mnc: 1
    },
    {
      network: Network.Econet,
      mnc: 4
    },
    {
      network: Network.Telecel,
      mnc: 3
    }
  ];

  selectedNetwork!: {
    network: Network,
    mnc: number
  };

  filterCellTowersByProvider = () => {
    console.log(this.selectedNetwork);

    this.filteredCellTowers = this.cellTowers.filter(ct => ct.mnc === this.selectedNetwork.mnc);

    console.log(this.filteredCellTowers);

  }

  updateMapMarkers() {
    this.loading = true;

    const color = this.getNetworkColor(this.selectedNetwork.network);
    this.filterCellTowersByProvider();
    this.markers.forEach(marker => marker.remove());
    this.filteredCellTowers.forEach(ct => {
      const marker = L.marker([ct.lat, ct.lon], {
        icon: L.divIcon({
          className: 'custom-marker',
          html: `<i class="fas fa-broadcast-tower fa-lg" style="color:${color};"></i>`
        }),
        title: `${ct.network} Tower`
      });
      this.markerClusterGroup.addLayer(marker);
    });
    this.addMarkers();
    this.centerMap();

    this.loading = false;
  }


  private getNetworkColor(network: Network): string {
    switch (network) {
      case 'Econet':
        return 'blue';
      case 'Netone':
        return 'orange';
      case 'Telecel':
        return 'red';
      default:
        return 'gray';
    }
  }

  private map!: L.Map;

  markerClusterGroup!: L.MarkerClusterGroup;

  markers: L.Marker[] = [
    L.marker([-17.8292, 31.0522])
  ];


  private initializeMap() {
    const baseMapURl = 'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png'
    this.map = L.map('map');
    L.tileLayer(baseMapURl).addTo(this.map);
    this.markerClusterGroup = L.markerClusterGroup();
    this.map.addLayer(this.markerClusterGroup);
  }


  private addMarkers() {
    this.markers.forEach(marker => marker.addTo(this.map));
    this.markers.forEach(marker => marker.bindPopup('Harare'));
  }

  private centerMap() {
    // Create a LatLngBounds object to encompass all the marker locations
    const bounds = L.latLngBounds(this.markers.map(marker => marker.getLatLng()));

    // Fit the map view to the bounds
    this.map.fitBounds(bounds);
  }
}
