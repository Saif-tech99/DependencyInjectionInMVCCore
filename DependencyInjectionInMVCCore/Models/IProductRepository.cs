using System.Collections.Generic;

namespace DependencyInjectionInMVCCore.Models
{
    public interface IProductRepository
    {
        Product FindProduct(Product product);
        List<Product> GetAllProduct();
    }
}