using inventory.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace inventory.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InventoryController : ControllerBase
{
  private readonly ILogger<InventoryController> _logger;
  private InventoryRepository _repository;

  public InventoryController(ILogger<InventoryController> logger, InventoryRepository repository)
  {
    _logger = logger;
    this._repository = repository;
  }

  [HttpGet("{id}")]
  public int Get(int id)
  {
    return _repository.GetQuantity(id);
  }

}
