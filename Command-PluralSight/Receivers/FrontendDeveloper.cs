using System;

namespace CommandPluralSight
{
	public class FrontendDeveloper : IDeveloper
	{
		public void CallApi()
		{
			Console.WriteLine ("Write some javascript");
		}

		public void FixBugs()
		{
			Console.WriteLine ("Fix some frontend bugs");
		}
	}
}

