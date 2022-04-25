namespace inventory.Repositories;
public class InventoryRepository
{
  private readonly ILogger<InventoryRepository> _logger;

  private static readonly IDictionary<int, int> products;
  static InventoryRepository()
  {
    products = new Dictionary<int, int>();
    products.Add(1, 10);
    products.Add(2, 10);
    products.Add(3, 10);
  }

  public InventoryRepository(ILogger<InventoryRepository> logger)
  {
    _logger = logger;
  }
  public int GetQuantity(int id)
  {
    return products[id];
  }

}