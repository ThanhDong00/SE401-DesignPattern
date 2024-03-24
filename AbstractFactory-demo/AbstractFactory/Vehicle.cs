

namespace AbstractFactory
{
	public interface Vehicle
	{
		string buy();
		string speed();
		string range();
		string hp();
	}
	class Car : Vehicle
	{
		int money = 100000;
		int speed = 100;
		int range = 700;
		int hp = 1200;
		string Vehicle.buy()
		{
			return $"you spent {money} on this car";
		}

		string Vehicle.hp()
		{
			return $"HP: {hp}";
		}

		string Vehicle.range()
		{
			return $"you can drive ${range} without refuel";
		}

		string Vehicle.speed()
		{
			return $"this car can exceed to {speed}";
		}
	}

	class Tank : Vehicle
	{
		int money = 200000;
		int speed = 60;
		int range = 400;
		int hp = 6000;
		string Vehicle.buy()
		{
			return $"you spent {money} on this tankkkk";
		}

		string Vehicle.hp()
		{
			return $"HP: {hp}";
		}

		string Vehicle.range()
		{
			return $"you can drive ${range} without refuel";
		}

		string Vehicle.speed()
		{
			return $"this tank can exceed to {speed}";
		}
	}
}
