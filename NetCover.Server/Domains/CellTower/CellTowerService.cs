using Microsoft.EntityFrameworkCore;
using NetCover.Server.Data;

namespace NetCover.Server.Domains.CellTower;

public interface ICellTowerService
{
     Task<List<CellTowerDto>> GetCellTowers();
     Task<List<CellTowerDto>> GetCellTowersByProvider(int provider);

}
public class CellTowerService :ICellTowerService
{
     private readonly RepositoryContext _repository;
     public CellTowerService( RepositoryContext repository)
     {
          _repository = repository;
     }
     
     public async Task<List<CellTowerDto>> GetCellTowers()
     {
          var cellTowers = await _repository.CellTowers.Select(x=>new CellTowerDto()
          {
               MNC = x.MNC,
               Lon = x.Longitude,
               Lat = x.Latitude
          }).ToListAsync();
          return cellTowers;
     }
     
     public async Task<List<CellTowerDto>> GetCellTowersByProvider(int provider)
     {
          var cellTowers = await _repository.CellTowers.Select(x=>new CellTowerDto()
          {
               MNC = x.MNC,
               Lon = x.Longitude,
               Lat = x.Latitude
          }).Where(ct => ct.MNC == provider).ToListAsync();
          return cellTowers;
     }
     
}