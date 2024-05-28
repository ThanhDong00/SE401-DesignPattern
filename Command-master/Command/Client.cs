namespace Command
{
	class Program
	{
		static void Main(string[] args)
		{
			Light light = new Light();
			ICommand onCommand = new LightOnCommand(light);
			ICommand offCommand = new LightOffCommand(light);

			RemoteControl remote = new RemoteControl(onCommand, offCommand);

			remote.PressOnButton();  // bật
			remote.PressOffButton(); // tắt
		}
	}
}