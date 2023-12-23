namespace netBootcamp.Models
{
    public class Category
    {
        public Category(int ID, string CategoryName)
        {
            this.ID = ID;
            this.CategoryName = CategoryName;
        }
        public int ID { get; set; }
        public string CategoryName { get; set; }
    }
}
