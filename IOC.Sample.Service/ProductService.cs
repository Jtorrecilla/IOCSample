using IOC.Sample.Model;
using IOC.Sample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Sample.Service
{
    public class ProductService
    {
        private readonly ProductRepository repo;
        public ProductService()
        {
            repo = new ProductRepository();
        }

        public IEnumerable<Product> GetProducts()
        {
            return repo.GetAll();
        }

    }
}
