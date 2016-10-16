using IOC.Sample.Model;
using IOC.Sample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Sample.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repo;
        public ProductService(IProductRepository repository)
        {
            repo = repository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return repo.GetAll();
        }

    }
}
