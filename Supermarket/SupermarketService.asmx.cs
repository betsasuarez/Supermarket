using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Supermarket
{
    /// <summary>
    /// Descripción breve de SupermarketService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SupermarketService : System.Web.Services.WebService
    {
        private static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Huevo" },
        new Product { Id = 2, Name = "Carne" },
        new Product { Id = 3, Name = "Pollo" },
        new Product { Id = 4, Name = "Arroz" }
    };

        [WebMethod]
        public List<Product> GetAllProducts()
        {
            return products;
        }

        [WebMethod]
        public Product GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
        }

        [WebMethod]
        public void AddProduct(string name)
        {
            int nextId = products.Count + 1;
            Product newProduct = new Product { Id = nextId, Name = name };
            products.Add(newProduct);
        }

        [WebMethod]
        public void UpdateProduct(int id, string newName)
        {
            Product existingProduct = products.Find(p => p.Id == id);

            if (existingProduct != null)
            {
                existingProduct.Name = newName;
            }
        }

        [WebMethod]
        public void DeleteProduct(int id)
        {
            products.RemoveAll(p => p.Id == id);
        }
    }
}
