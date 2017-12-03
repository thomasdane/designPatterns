using System;
using System.Collections.Generic;

namespace CommandOutputTypes
{
	public class Results
	{
		public IDictionary<string, string> Generate()
		{
			//More complicated work could happen here
			var results = new Dictionary<string, string>();
			results.Add ("ID", "Message");
			results.Add ("1", "Hello World");
			return results;
		}
	}
}