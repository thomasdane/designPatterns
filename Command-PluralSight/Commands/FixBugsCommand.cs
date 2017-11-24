using System;

namespace CommandPluralSight
{
	public class FixBugsCommand : ICommand
	{
		IDeveloper _developer;

		public FixBugsCommand (IDeveloper developer)
		{
			_developer = developer;
		}

		public void Execute()
		{
			_developer.FixBugs();
		}

	}
}

