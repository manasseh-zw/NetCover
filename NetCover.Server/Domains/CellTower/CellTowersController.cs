using Microsoft.AspNetCore.Mvc;

namespace NetCover.Server.Domains.CellTower;

[ApiController]
[Route("api/[controller]")]
public class CellTowersController:ControllerBase
{
    private readonly ICellTowerService _service;

    public CellTowersController(ICellTowerService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetCellTowers()
    {
        var cellTowers = await _service.GetCellTowers();
        return Ok(cellTowers);
    }
    
    
    [HttpGet("{provider:int}")]
    public async Task<IActionResult> GetCellTowersByProvider(int provider)
    {
        var cellTowers = await _service.GetCellTowersByProvider(provider);
        return Ok(cellTowers);
    }
    
}