using BLL.Entity;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductRepositoryMoq : IProductRepository
    {
        List<Product> _database; 
        public ProductRepositoryMoq()
        {

            ProductCategory category1 = new ProductCategory()
            {
                Name = "Category1",
            };

            ProductCategory category2 = new ProductCategory()
            {
                Name = "Category2",
            };

            _database = new List<Product>()
            {
                new Product()
                {
                    Name = "Product1.1",
                    Price = 200,
                    Category= category1,
                },
                new Product()
                {
                    Name = "Product1.2",
                    Price = 150,
                    Category= category1,
                },
                new Product()
                {
                    Name = "Product1.3",
                    Price = 300,
                    Category= category1,
                },
                new Product()
                {
                    Name = "Product2.1",
                    Price = 20,
                    Category= category2,
                },
                new Product()
                {
                    Name = "Product2.2",
                    Price = 201,
                    Category= category2,
                },
                new Product()
                {
                    Name = "Product2.3",
                    Price = 120,
                    Category= category2
                }
            };
        }
        public async Task<bool> Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetByName(string name)
        {
            return _database.FirstOrDefault(prod => prod.Name == name);
        }

        public async Task<List<Product>> Select()
        {
            return   _database;
        }

        public async Task<bool> Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
