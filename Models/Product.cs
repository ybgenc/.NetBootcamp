namespace netBootcamp.Models
{
    public class Product
    {
        public Product(int ID, string ProductName, string UnitPrice, Category category)
        {
            this.ID = ID;
            this.ProductName = ProductName;
            this.UnitPrice = UnitPrice;
            this.Category = category;
        }

        public int ID { get; set; }
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
        public Category Category { get; set; }
    }
}
