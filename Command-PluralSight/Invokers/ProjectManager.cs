using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandPluralSight
{
	public class ProjectManager
	{
		public void GetStuffDone(List<ICommand> commands)
		{
			commands.ForEach(c => c.Execute());
		}
	}
}

