using System;

namespace CommandPluralSight
{
	public class BackendDeveloper : IDeveloper
	{
		public void BuildApi()
		{
			Console.WriteLine ("Build an API");
		}

		public void FixBugs()
		{
			Console.WriteLine ("Fix a backend issue");
		}
	}
}

