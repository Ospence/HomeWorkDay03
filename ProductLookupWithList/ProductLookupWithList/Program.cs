using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProductLookupWithList
{

    class Product
    {
        public string  Id { get; set; }
        public string  Name { get; set; }
        public decimal Price { get; set; }
    }

    class ProductCatalog
    {
        public List<Product> ProductList { get; set; }
        public Dictionary<string, Product> ProductDictionary { get; set; }

        public ProductCatalog()
        {
             ProductDictionary = new Dictionary<string, Product>();
            ProductList = new List<Product>();



             ProductList.Add(new Product {Id = "BSD65", Name = "Dell", Price = 650 });
             ProductList.Add(new Product {Id = "121", Name = "HP", Price = 550 });
             ProductList.Add(new Product {Id = "12as1", Name = "Apple", Price = 6500 });


            foreach (var item in ProductList)
            {
                ProductDictionary.Add(item.Id, item);
            }

        }

        public Product Lookup(string id)
        {
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].Id == id )
                {
                    return ProductList[i];
                }
            }
            return null;
        }
        
        public Product LookUpKey(string id)
        {
            if (ProductDictionary.ContainsKey(id))
            {
                return ProductDictionary[id];
            }
            return null;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

            Debug.Assert(new ProductCatalog().LookUpKey("121").Price == 550, "Not true");
             
        }

    }
}

