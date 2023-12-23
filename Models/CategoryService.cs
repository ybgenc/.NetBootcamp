namespace netBootcamp.Models
{
    public class CategoryService
    {
        public static List<Category> GetCategory()
        {
            var categorys = new List<Category>();
            categorys.Add(new Category(1, "2 wheel"));
            categorys.Add(new Category(2, "4 wheel"));
            categorys.Add(new Category(3, "6 wheel"));
            categorys.Add(new Category(4, "0 wheel"));

            return categorys;
        }
    }
}
