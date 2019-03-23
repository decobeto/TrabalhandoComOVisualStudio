using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TrabalhandoComOVisualStudio.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products
            = new Dictionary<string, Product>();

        public static SimpleRepository SharedRepository => sharedRepository;

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product {Name = "Barco inflavel", Price = 375},
                new Product {Name = "Bola de Futebol", Price = 75},
                new Product {Name = "Bola de basquete", Price = 75},
                new Product {Name = "Raquete", Price = 275}
            };

           foreach(var p in initialItems) { AddProduct(p); }
        }
        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product p) => products.Add(p.Name, p);
    }
}
