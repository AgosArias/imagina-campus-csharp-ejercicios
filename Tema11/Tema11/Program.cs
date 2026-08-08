using System;

namespace Tema11
{
	public class Product
	{
		public string Name { get; set; }
		public string Category { get; set; }
		public double Price { get; set; }
		public int Stock { get; set; }
	}
	internal class Program
	{
		static void Main()
		{
			var products = new List<Product>
			{
				new Product { Name = "Portátil", Category = "Electrónica", Price = 800, Stock = 1 },
				new Product { Name = "Africanus (Santiago Posteguillo)", Category = "Libros", Price = 20, Stock = 27 },
				new Product { Name = "Smartphone", Category = "Electrónica", Price = 600, Stock = 0 },
				new Product { Name = "Mesita de noche", Category = "Muebles", Price = 50, Stock = 12 },
				new Product { Name = "Fundación e Imperio (Isaac Asimov)", Category = "Libros", Price = 13, Stock = 8 },
				new Product { Name = "Luces de Bohemia (Ramón María del Valle-Inclán)", Category = "Libros", Price = 48, Stock = 0 },
				new Product { Name = "Silla de oficina", Category = "Muebles", Price = 250, Stock = 4 },
				new Product { Name = "La Perra (Alberto Val)", Category = "Libros", Price = 18, Stock = 32 },
			};

			var avgPrice = products.Where(p => p.Stock > 0 ).Average( p => p.Price);
			Console.WriteLine("El precio medio de los productos en stock es " + avgPrice);

			var electronics = products.Where( p => p.Category.Equals("Electrónica"))
			.Select(p => p.Name);

			products.Where(p => p.Category.Equals("Libros"))
			.Select(p => new { Title = p.Name.Substring(0, p.Name.IndexOf('(') - 1), Author = p.Name.Substring(p.Name.IndexOf('(') + 1, p.Name.Length - p.Name.IndexOf('(') - 2).ToUpper() })
			.ToList().ForEach(l => Console.WriteLine("Título: {0}. Autor: {1}", l.Title, l.Author));
			
			products.OrderBy(p => p.Category).ThenBy(p => p.Stock).ToList()
			.ForEach(p => Console.WriteLine("{0} - {1} - {2}", p.Category, p.Name, p.Stock));

			var total = products.Sum(p => p.Price * p.Stock);
			Console.WriteLine("El precio total de las unidades en stock es: " + total);

			var maxStock = products.Max(p => p.Stock);
			var maxStockProduct = products.Where(p => p.Stock == maxStock).First();
			Console.WriteLine("El producto con mayor stock es " + maxStockProduct.Name);

			var cheapProducts = products.Count(p => p.Price < 100);
			Console.WriteLine("Número de productos con precio inferior a 100e: " + cheapProducts);

			var allStock = products.All(p => p.Stock > 0);
			Console.WriteLine("Hay stock de todos los productos: " + allStock);
			
			var expensiveProduct = products.Any(p => p.Price > 500);
			Console.WriteLine("Hay algún producto de más de 500e: " + expensiveProduct);
		}
	}

}