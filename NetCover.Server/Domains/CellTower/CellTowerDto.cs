namespace NetCover.Server.Domains.CellTower;

public record CellTowerDto
{
    public int MNC { get; set; }
    private string _network;
    public string Network
    {
        get
        {
            return MNC switch
            {
                1 => "Netone",
                3 => "Telecel",
                4 => "Econet",
                _ => "Fixed"
            };
        }
        set
        {
            _network = value;
        }
    }
    public double Lon { get; set; }
    public double Lat { get; set; }
};