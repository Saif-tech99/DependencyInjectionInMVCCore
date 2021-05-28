using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionInMVCCore.Models
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> Products = new List<Product>();


        public Product FindProduct(Product product)
        {
            var faind = Products.Find(p => p.Id == product.Id);
            return faind;
        }

        public List<Product> GetAllProduct()
        {
            Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "TV";
            p1.Price = 500.99m;

            Product p2 = new Product();
            p2.Id = 2;
            p2.Name = "Laptop";
            p2.Price = 800.99m;

            Product p3 = new Product();
            p3.Id = 3;
            p3.Name = "GSM";
            p3.Price = 9000.99m;

            Products.Add(p1);
            Products.Add(p2);
            Products.Add(p3);

            return Products;
        }
    }
}
