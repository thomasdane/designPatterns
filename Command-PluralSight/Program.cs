using System;
using System.Collections.Generic;

//decouples clients that execute command from details of command iteself
//client knows about a command object which has an execute method
//could also have validate or undo methods

namespace CommandPluralSight
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Create receivers
			var frontendDeveloper = new FrontendDeveloper ();
			var backendDeveloper = new BackendDeveloper ();

			//Create build commands
			var buildApi = new BuildApiCommand (backendDeveloper);
			var callApi = new CallApiCommand (frontendDeveloper);
			var buildCommands = new List<ICommand>{ buildApi, callApi };

			//Create fix commands
			var fixFrontendBugs = new FixBugsCommand(backendDeveloper);
			var fixBackendBugs = new FixBugsCommand (frontendDeveloper);
			var fixCommands = new List<ICommand>{ fixFrontendBugs, fixBackendBugs };

			//Create invoker
			var pm = new ProjectManager();
			pm.GetStuffDone(buildCommands);
			pm.GetStuffDone(fixCommands);

		}
	}
}
