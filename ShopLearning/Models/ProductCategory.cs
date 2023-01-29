namespace ShopLearning.Models
{
    public class ProductCategory
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }    
        public List<ProductModel> Products { get; set; }    
    }
}
