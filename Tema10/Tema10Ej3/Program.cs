using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tema10Ej3
{
    internal class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Name = "Tomates", Price = 2.48, Stock = 200, IsAvailable = true },
                new Product() { Name = "Pimientos", Price = 1.99, Stock = 20, IsAvailable = false },
                new Product() { Name = "Manzanas", Price = 2.85, Stock = 300, IsAvailable = true },
                new Product() { Name = "Aguacates", Price = 6.99, Stock = 30, IsAvailable = true },
                new Product() { Name = "Cebollas", Price = 1.59, Stock = 185, IsAvailable= true },
            };
            Console.WriteLine(JsonSerializer.Serialize(products));
            XmlSerializer productsXML = new XmlSerializer(typeof(List<Product>));

            using (StringReader stringReader = new StringReader(File.ReadAllText("product.xml")))
            {
                var productList = productsXML.Deserialize(stringReader) as List<Product>;
                if (productList != null)
                {
                    foreach(var product in productList)
                        Console.WriteLine(product.Name + "("+ product.Price+ ")");
                }
            }
        }
    }
    public class Product
    {
        public string Name {get;set;}
        public double Price {get;set;}
        public int Stock {get;set;}
        [JsonIgnore]
        public bool IsAvailable {get;set;}
    }
}
