namespace AbstractFactory
{
	public class Application
	{
		public static WeaponFactory takeWeaponFactory(string weaponName)
		{
			if(weaponName.Equals("knife",StringComparison.OrdinalIgnoreCase))
				return new KnifeWeaponFactory();
			else if(weaponName.Equals("awm", StringComparison.OrdinalIgnoreCase))
				return new AWMWeaponFactory();
			else
				return new AK_47WeaponFactory();
		}
		public static VehicleFactory takeVehicleFactory(string weaponName)
		{
			if (weaponName.Equals("car", StringComparison.OrdinalIgnoreCase))
				return new CarVehicleFactory();
			else
				return new TankVehicleFactory();
		}
	}
}
