
var catalogue = new Warehouse();

IEnumerable<Product> product = catalogue.GetProductsAsEnumerable(); // product <- 4
var selection1 = product.Where(s => s.Id > 3000); // selection1 <- 2

foreach (var s in selection1)              // 7183
{                                          // 3989
	Console.WriteLine(s.Id);
}
Console.WriteLine("--------------------------");

IQueryable<Product> query = catalogue.GetProductsAsQueryable(); // query <- 0
var selection2 = query.Where(s => s.Id > 3000); // selection2 <- 0
var finalData = selection2.ToList(); // Select all from product where id > 3000

foreach (var s in selection2)                // 7183
{                                            // 3989
    Console.WriteLine(s.Id);                 
}

Console.ReadKey();

public class Product
{
	public int Id { get; set; }
	public Product(int id) =>Id = id; 	
}
public class Warehouse
{
	public List<Product> products = new List<Product>();
	public Warehouse()
	{
        products.Add(new Product(2514));
        products.Add(new Product(1521));
        products.Add(new Product(7183));
        products.Add(new Product(3989));
    }
	public IEnumerable<Product> GetProductsAsEnumerable() => products.AsEnumerable();
	public IQueryable<Product> GetProductsAsQueryable() => products.AsQueryable();
}