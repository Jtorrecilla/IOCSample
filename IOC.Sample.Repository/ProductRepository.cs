using IOC.Sample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Sample.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            return Enumerable.Range(1, 50).Select(i => new Product { Id = i, Name = $"Product Name{i}" });
        }
    }
}
