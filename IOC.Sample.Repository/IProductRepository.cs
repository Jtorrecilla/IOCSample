using System.Collections.Generic;
using IOC.Sample.Model;

namespace IOC.Sample.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}