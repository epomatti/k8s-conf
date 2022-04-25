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

  public Product GetProduct(int Id)
  {
    return products[Id];
  }

}