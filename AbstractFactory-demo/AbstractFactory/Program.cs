namespace AbstractFactory
{
	public class Program
	{
		
		static void Main(string[] args)
		{
			string product = "";
			string type = "";

			void ask()
			{
				Console.WriteLine("What do you want");
				product = Console.ReadLine();
				Console.WriteLine("what type do you want");
				type = Console.ReadLine();
			}
			void giveResult()
			{
				if (product.Equals("weapon", StringComparison.OrdinalIgnoreCase))
				{
					Application.takeWeaponFactory(type).useWeapon();
				} else
				{
					Application.takeVehicleFactory(type).useVehicle();
				}

			}

			ask();

			giveResult();
		}
	}
}
