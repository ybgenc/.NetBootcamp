namespace netBootcamp.Models
{
    public class ProductService
    {
        public static List<Product> GetProducts()
        {
            var categories = CategoryService.GetCategory(); // Corrected method name

            var products = new List<Product>();
            products.Add(new Product(1, "Bike", "10000", categories[0]));
            products.Add(new Product(2, "Car", "20000", categories[1]));
            products.Add(new Product(3, "Truck", "30000", categories[2]));
            products.Add(new Product(4, "Boat", "40000", categories[3]));

            return products;
        }
    }
}
