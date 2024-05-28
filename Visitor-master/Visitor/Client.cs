using Visitor;

class Program
{
	static void Main(string[] args)
	{
		var cart = new List<IElement>
		{
			new Book { Title = "Design Patterns", Price = 97 },
			new Fruit { Name = "Apples", PricePerKg = 1.99, Weight = 2.5 }
		};

		var visitor = new PriceVisitor();

		foreach (var item in cart)
		{
			item.Accept(visitor);
		}

		Console.WriteLine($"Total price: {visitor.TotalPrice}");
	}
}
