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
			var jsonCommand = new OutputJsonCommand (results);

			Console.WriteLine ("============== CSV ==================");

			outputGenerator.ChooseOutputType(csvCommand);
			outputGenerator.Generate();

			Console.WriteLine ("============== JSON =================");

			outputGenerator.ChooseOutputType(jsonCommand);
			outputGenerator.Generate();
		}
	}
}
