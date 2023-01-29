using BLL.Entity;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL.Services
{
	public class ProductServices : IProductServices
	{
		IProductRepository _repository;
		public ProductServices(IProductRepository repository)
		{
			_repository= repository;
		}
		public async Task<bool> CreateProduct(Product entity)
		{
			return await _repository.Create(entity); 
		}

		public async Task<Product> DeleteProduct(Product entity)
		{
			return await _repository.Delete(entity);
		}

		public async Task<Product> GetProduct(Guid id)
		{
			return await _repository.Get(id);
		}

		public async Task<Product> GetProductByName(string name)
		{
			return await _repository.GetByName(name);
		}

		public async Task<Product> GetProductByPrice(double price)
		{
			var result = await _repository.Select();

			return result.FirstOrDefault(prod=>prod.Price == price);
		}

		public async  Task<IEnumerable<Product>> SelectProducts()
		{
			return await _repository.Select();
			 
		}

		public async Task<IEnumerable<Product>> SelectProductsByCategory(string category)
		{
			var result = await _repository.Select();
			return result.Where(prod => prod.Category.Name == category).ToList();
		}

		public async Task<bool> UpdateProduct(Product entity)
		{
			return await _repository.Update(entity);
		}
	}
}
