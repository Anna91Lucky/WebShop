namespace ShopLearning.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Rate { get; }
        //public GlobalCategory KeyWords { get; set; }
        public ProductCategory Category { get; set; }
                                        
    }
}
