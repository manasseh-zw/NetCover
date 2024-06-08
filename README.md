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

#### Demo Video

`Click this link:`

https://www.canva.com/design/DAGHgP8njfM/Oh97ane90XrF5F9wtVkyxQ/watch?utm_content=DAGHgP8njfM&utm_campaign=share_your_design&utm_medium=link&utm_source=shareyourdesignpanel

#### Select Network

`choose an option`

![img1](https://github.com/manasseh-zw/NetCover/assets/112127696/b4d476f6-0a4d-4681-b9ab-b8b9c9e44e7f)

#### Interact with Map

`map`

![img2](https://github.com/manasseh-zw/NetCover/assets/112127696/dcd06c3e-d682-4488-8bfe-96b62d6e4830)

#### Multiple Views

![Galaxy-Fold2-localhost (1)](https://github.com/manasseh-zw/NetCover/assets/112127696/85105571-9c86-4900-b6e5-b8f07820c6b7)


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
