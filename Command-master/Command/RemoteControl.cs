using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	// invoker
	public class RemoteControl
	{
		private ICommand _onCommand;
		private ICommand _offCommand;

		public RemoteControl(ICommand onCommand, ICommand offCommand)
		{
			_onCommand = onCommand;
			_offCommand = offCommand;
		}

		public void PressOnButton()
		{
			_onCommand.Execute();
		}

		public void PressOffButton()
		{
			_offCommand.Execute();
		}
	}

}
