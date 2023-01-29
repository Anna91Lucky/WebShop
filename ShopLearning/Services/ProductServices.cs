using AutoMapper;
using ShopLearning.Intarfaces;
using ShopLearning.Models;
using System.Collections.Generic;
using BLL.Entity;

namespace ShopLearning.Services
{
    public class ProductServices : IProductServices
    {
        BLL.Interfaces.IProductServices _productService;
        IMapper _mapper;
        public ProductServices(IMapper mapper,BLL.Interfaces.IProductServices productService) 
        { 
            _productService= productService;
            _mapper= mapper;    
        }
        public Task<IBaseResponce<bool>> CreateProduct(ProductModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponce<ProductModel>> DeleteProduct(ProductModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponce<ProductModel>> GetProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponce<ProductModel>> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponce<ProductModel>> GetProductByPrice(double name)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponce<List<ProductModel>>> SelectProducts()
        {
            BaseResponce<List<ProductModel>> responce =new BaseResponce<List<ProductModel>>();

            try
            {
                var result = await _productService.SelectProducts();

              

                var mapping = _mapper.Map<List<ProductModel>>(result);
                responce.Data = mapping;                                                             //????????
                responce.StatusCode = ResultStatusCode.OK;
            }
            catch (Exception ex)
            {
                responce.StatusCode = ResultStatusCode.Error; 
            }
            return responce;
        }

        public Task<BaseResponce<List<ProductModel>>> SelectProductsByCategory(string Category)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponce<bool>> UpdateProduct(ProductModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
