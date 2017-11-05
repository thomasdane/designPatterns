using System;
namespace Command.Invokers
{
    public class Invoker
    {
		private ICommand _command;

        public Invoker(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            _command.Execute();    
        }

        public void Undo()
        {
            _command.Undo();
        }
    }
}
