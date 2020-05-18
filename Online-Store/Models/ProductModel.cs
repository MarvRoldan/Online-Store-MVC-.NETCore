using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Online_Store.Models
{
    public class ProductModel
    {
        private List<Product> Products;
        public ProductModel()
        {
            this.Products = new List<Product>() {
                new Product {
                    Id = "s01",
                    Name = "ObiWanLS",
                    Price = "$80 Billion",
                    Photo = "ObiWanLS.png"
                },
                new Product {
                    Id = "s02",
                    Name = "Jack's Sword",
                    Price = "$2 Trillion",
                    Photo = "Jack's_Sword.jpg"
                },
                new Product {
                    Id = "s03",
                    Name = "Callandor",
                    Price = "$580 Billion",
                    Photo = "Callanor.jpg"
                },
                new Product {
                    Id = "s04",
                    Name = "Yamato",
                    Price = "$790 Billion",
                    Photo = "Yamato.png"
                }
            };
        }

        public List<Product> FindAll()
        {
            return this.Products;
        }

        public Product Find(string id)
        {
            return this.Products.Single(p => p.Id.Equals(id));
        }
    }
}
