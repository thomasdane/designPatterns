using System;

namespace CommandPluralSight
{
	public class UpdateOrderCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine ("Deliver car to customer");
		}

	}
}

