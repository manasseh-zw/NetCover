namespace NetCover.Server.Data;

public class CellTowerModel
{
    public string Radio { get; set; }

    public int MCC { get; set; }

    public int MNC { get; set; }

    public int LAC { get; set; }

    public int CID { get; set; }

    public double Longitude { get; set; }

    public double Latitude { get; set; }
}