
namespace AbstractFactory
{
	public interface Weapon
	{
		string buy();
		string takeDamage();
		string playSound();
	}
	public class Knife : Weapon
	{
		private int money = 5000;
		private int damage = 150;
		private string sound = "knife.mp3";

		public string buy()
		{
			return $"money spent {money}";
		}

		public string takeDamage()
		{
			return $"damage dealt {damage}";
		}

		public string playSound()
		{
			return $"sound played {sound}";
		}
	}
	public class AWM : Weapon
	{
		private int money = 100000;
		private int damage = 200;
		private string sound = "awm.mp3";

		public string buy()
		{
			return $"money spent {money}";
		}

		public string takeDamage()
		{
			return $"damage dealt {damage}";
		}

		public string playSound()
		{
			return $"sound played {sound}";
		}
	}
	public class AK_47 : Weapon
	{
		private int money = 15000;
		private int damage = 80;
		private string sound = "ak_47.mp3";

		public string buy()
		{
			return $"money spent {money}";
		}

		public string takeDamage()
		{
			return $"damage dealt {damage}";
		}

		public string playSound()
		{
			return $"sound played {sound}";
		}
	}
}
