using System;

namespace CommandPluralSight
{
	public class CallApiCommand : ICommand
	{
		FrontendDeveloper _developer;

		public CallApiCommand(FrontendDeveloper developer)
		{
			_developer = developer;
		}

		public void Execute()
		{
			_developer.CallApi ();
		}
	}
}

