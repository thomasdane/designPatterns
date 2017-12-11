using System;
using System.Linq;

namespace CommandOutputTypes
{
	public class OutputJsonCommand : ICommand
	{
		Results _results;

		public OutputJsonCommand(Results results)
		{
			_results = results;
		}

		public void Execute()
		{
			var results = _results.Generate();

			var json = string.Format("{{{0}: {1}}}", results.Keys.First(), results.Values.First());

			Console.WriteLine(json);
		}
	}
}

