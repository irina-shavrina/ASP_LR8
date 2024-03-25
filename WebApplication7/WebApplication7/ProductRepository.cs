public static class ProductRepository
{
    static List<Product> Products = new List<Product>();

    public static IList<Product> GetProductList() => Products;

    public static bool AddProduct(Product? product)
    {
        if (product == null) {
            return false;
        }
        Products.Add(product);
        return true;
    }

    public static void init(){
        Products = new List<Product> {
            new Product("Product 1", 10m, DateTime.Today.AddDays(0)),
            new Product("Product 2", 15m, DateTime.Today.AddDays(-2)),
            new Product("Product 3", 11.05m, DateTime.Today.AddDays(-1)),
        }; 
    }
}

