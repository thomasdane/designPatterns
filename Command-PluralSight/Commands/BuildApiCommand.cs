using System;
using CommandPluralSight;

namespace CommandPluralSight
{
	public class BuildApiCommand : ICommand
	{
		BackendDeveloper _developer;

		public BuildApiCommand(BackendDeveloper developer)
		{
			_developer = developer;
		}

		public void Execute()
		{
			_developer.BuildApi ();
		}
	}
}

