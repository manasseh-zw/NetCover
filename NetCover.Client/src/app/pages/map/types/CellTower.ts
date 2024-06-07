import { Network } from "./Network";

export interface CellTower {
    mnc: number,
    network: Network,
    lat: number,
    lon: number
}