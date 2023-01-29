using BLL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface ICategoryRepository
    {
		Task<bool> Create(Product entity);
		Task<bool> Update(Product entity);
		Task<Product> Delete(Product entity);
		Task<List<Product>> Select();
		Task<Product> Get(Guid id);	
		Task<Product> GetByName(string name);

	}
}
