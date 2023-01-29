using ShopLearning.Models;

namespace ShopLearning.Intarfaces
{
    public interface IProductServices
    {
        Task<IBaseResponce<bool>> CreateProduct(ProductModel entity);
        Task<IBaseResponce<bool>> UpdateProduct(ProductModel entity);
       Task<IBaseResponce<ProductModel>> DeleteProduct(ProductModel entity);
        Task<BaseResponce<List<ProductModel>> >SelectProducts();
        Task<BaseResponce<List<ProductModel>>> SelectProductsByCategory(string Category);
        Task<IBaseResponce<ProductModel>> GetProduct(Guid id);
        Task<IBaseResponce<ProductModel>> GetProductByName(string name);
        Task<IBaseResponce<ProductModel>> GetProductByPrice(double name);
    }
}
