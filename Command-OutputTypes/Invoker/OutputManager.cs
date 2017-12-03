using System;

namespace CommandOutputTypes
{
	public class OutputGenerator
	{
		ICommand _command;

		public void ChooseOutputType(ICommand command)
		{
			_command = command;
		}

		public void Generate()
		{
			_command.Execute();
		}
	}
}

