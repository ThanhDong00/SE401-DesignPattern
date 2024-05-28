
namespace Command
{
	// Receiver
	public class LightOnCommand : ICommand
	{
		private readonly Light _light;

		public LightOnCommand(Light light)
		{
			_light = light;
		}

		public void Execute()
		{
			_light.TurnOn();
		}
	}

	public class LightOffCommand : ICommand
	{
		private readonly Light _light;

		public LightOffCommand(Light light)
		{
			_light = light;
		}

		public void Execute()
		{
			_light.TurnOff();
		}
	}

}
