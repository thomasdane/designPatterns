using System;
using System.Linq;

namespace CommandOutputTypes
{
	public class OutputCsvCommand : ICommand
	{
		Results _results;

		public OutputCsvCommand(Results results)
		{
			_results = results;
		}

		public void Execute()
		{
			var results = _results.Generate();

			var csv = String.Join(
				Environment.NewLine,
				results.Select(d => d.Key + "," + d.Value)
			);

			Console.WriteLine(csv);
		}
	}
}

