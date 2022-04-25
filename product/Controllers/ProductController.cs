using Microsoft.AspNetCore.Mvc;
using product.Models;
using product.Repositories;

namespace product.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
  private readonly ILogger<ProductController> _logger;

  private ProductRepository _repository;

  public ProductController(ILogger<ProductController> logger, ProductRepository repository)
  {
    _logger = logger;
    this._repository = repository;
  }

  [HttpGet("{id}")]
  public async Task<Product> Get(int id)
  {
    return await _repository.GetProduct(id);
  }
}
