using System;

namespace CommandPluralSight
{
	public class CreateOrderCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("New car created");
		}
	}
}

