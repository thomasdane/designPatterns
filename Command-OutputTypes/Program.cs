using System;

namespace CommandOutputTypes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var outputGenerator = new OutputGenerator ();
			var results = new Results ();
			var csvCommand = new OutputCsvCommand(results);

			outputGenerator.ChooseOutputType(csvCommand);
			outputGenerator.Generate ();
		}
	}
}
