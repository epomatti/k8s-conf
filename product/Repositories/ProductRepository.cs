using product.Models;

namespace product.Repositories;

public class ProductRepository
{
  private static readonly IDictionary<int, Product> products;
  static ProductRepository()
  {
    products = new Dictionary<int, Product>();

    Product water = new Product() { Id = 1, Name = "Water", Price = 1 };
    Product soda = new Product() { Id = 2, Name = "Soda", Price = 2 };
    Product beer = new Product() { Id = 3, Name = "Beer", Price = 5 };

    products.Add(water.Id, water);
    products.Add(soda.Id, soda);
    products.Add(beer.Id, beer);
  }

  public async Task<Product> GetProduct(int Id)
  {
    Product product = products[Id];
    product.Quantity = await GetQuantity(Id);
    return product;
  }

  static readonly HttpClient client = new HttpClient();

  private async Task<int> GetQuantity(int Id)
  {
    String quantity = await client.GetStringAsync($"http://localhost:5236/api/inventory/{Id}");
    return int.Parse(quantity);
  }

}