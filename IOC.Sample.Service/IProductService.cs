using System.Collections.Generic;
using IOC.Sample.Model;

namespace IOC.Sample.Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}