using System;
using System.Linq;
using Newtonsoft.Json;

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

            var json = JsonConvert.SerializeObject(results);

			Console.WriteLine("foo");
		}
	}
}

