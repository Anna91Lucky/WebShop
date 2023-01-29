using BLL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface IProductServices
	{
		Task<bool> CreateProduct(Product entity);
		Task<bool> UpdateProduct(Product entity);
		Task<Product> DeleteProduct(Product entity);
		Task<IEnumerable<Product>> SelectProducts();
		Task<IEnumerable<Product>> SelectProductsByCategory(string Category);
		Task<Product> GetProduct(Guid id);	
		Task<Product> GetProductByName(string name);
		Task<Product> GetProductByPrice(double name);

	}
}
