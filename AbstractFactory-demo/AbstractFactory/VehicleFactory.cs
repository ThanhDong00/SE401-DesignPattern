

namespace AbstractFactory
{
	public interface VehicleFactory
	{
		void buyVehicle();
		void useVehicle();
		void limitOfVehicle();
		void hitPoint();
	}
	class CarVehicleFactory : VehicleFactory
	{
		Vehicle car = new Car();
		public void buyVehicle()
		{
            Console.WriteLine(car.buy());
        }

		public void hitPoint()
		{
            Console.WriteLine(car.hp());
        }

		public void limitOfVehicle()
		{
            Console.WriteLine(car.range());
        }

		public void useVehicle()
		{
            Console.WriteLine(car.speed());
        }
	}

	class TankVehicleFactory : VehicleFactory
	{
		Vehicle tank = new Tank();
		public void buyVehicle()
		{
			Console.WriteLine(tank.buy());
		}

		public void hitPoint()
		{
			Console.WriteLine(tank.hp());
		}

		public void limitOfVehicle()
		{
			Console.WriteLine(tank.range());
		}

		public void useVehicle()
		{
			Console.WriteLine(tank.speed());
		}
	}
}
