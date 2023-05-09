using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Command
{
    class WorkQueue
    {
        private IList<ICommand> Commands = new List<ICommand>();
        public void Add(ICommand command)
        {
            Commands.Add(command);
        }

        public void Proccess() 
        { 
            foreach(var command in Commands)
            {
                command.Execute();
            }
        }
    }
}
