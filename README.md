# NetCover

## Project Overview

The NetCover project is a web application designed to visualize the distribution of cell towers across Zimbabwe using data from OpenCellID. The application provides an interactive map with markers representing cell towers, allowing users to filter the towers by network provider.

### Features

- **Map Visualization**: Display cell towers on an interactive map using Leaflet.
- **Network Filtering**: Filter cell towers by network provider (Econet, Netone, Telecel, Fixed).
- **Clustered Markers**: Efficiently handle large numbers of markers with clustering.
- **Custom Markers**: Use Font Awesome icons for markers with color coding based on the network provider.
- **Loading Indicator**: Display a loading spinner while the map is updating.

### Tech Stack

- **Backend**: ASP.NET Core Web API
  - **Database**: PostgreSQL (using Entity Framework Core for ORM)
  - **Hosting**: Local setup (not hosted due to Azure free plan limitations)
- **Frontend**: Angular
  - **Map Library**: Leaflet with `leaflet.markercluster` plugin
  - **UI Components**: PrimeNG
  - **CSS Utilities**: PrimeFlex
  - **Icons**: Font Awesome

### Screenshots and Video Demo

#### Network Provider Selection

`Select Network Provider`

![Network Provider Selection](./.docs/demo.mp4)

#### Map Visualization

`Map with Cell Towers`

![Map Visualization](./images/map-visualization.png)

#### Loading Indicator

`Loading Indicator`

![Loading Indicator](./images/loading-indicator.png)

### Video Demo

Watch the video demo [here](./videos/network-coverage-demo.mp4).

## Folder Structure

```bash
- backend/
  - Controllers/
  - Domains/
    - CellTower/
      - CellTowerService.cs
      - CellTowerController.cs
      - CellTowerDto.cs
  - Data/
    - Models/
    - Repository/
  - Program.cs
  - Startup.cs
  - appsettings.json
- frontend/
  - src/
    - app/
      - components/
        - map/
          - map.component.ts
          - map.component.html
          - map.component.css
      - services/
        - map.service.ts
    - assets/
      - styles/
        - custom.css
    - index.html
- README.md
- .gitignore
- package.json
