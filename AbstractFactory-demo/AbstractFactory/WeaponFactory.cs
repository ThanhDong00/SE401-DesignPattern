

namespace AbstractFactory
{
	public interface WeaponFactory
	{
		void buyWeapon();
		void useWeapon();
		void playSound();
	}

	class KnifeWeaponFactory : WeaponFactory
	{
		Weapon knife = new Knife();
		public void buyWeapon()
		{
            Console.WriteLine(knife.buy());
        }

		public void playSound()
		{
			Console.WriteLine(knife.playSound());
		}

		public void useWeapon()
		{
			Console.WriteLine(knife.takeDamage());
		}
	}

	class AWMWeaponFactory : WeaponFactory
	{
		Weapon awm = new AWM();
		public void buyWeapon()
		{
			Console.WriteLine(awm.buy());
		}

		public void playSound()
		{
			Console.WriteLine(awm.playSound());
		}

		public void useWeapon()
		{
			Console.WriteLine(awm.takeDamage());
		}
	}

	class AK_47WeaponFactory : WeaponFactory
	{
		Weapon ak = new AK_47();
		public void buyWeapon()
		{
			Console.WriteLine(ak.buy());
		}

		public void playSound()
		{
			Console.WriteLine(ak.playSound());
		}

		public void useWeapon()
		{
			Console.WriteLine(ak.takeDamage());
		}
	}
}
