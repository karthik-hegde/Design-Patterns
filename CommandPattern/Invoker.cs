using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Invoker
    {
        private readonly List<ICommand> _commandStack = new List<ICommand>();
        private int _currentCommandIndex = -1;
        public void ExecuteCommand(ICommand command)
        {
            if (_currentCommandIndex < _commandStack.Count - 1)
            {
                _commandStack.RemoveRange(_currentCommandIndex + 1, _commandStack.Count - _currentCommandIndex - 1);
            }
            command.Execute();
            _commandStack.Add(command);
            _currentCommandIndex++;
        }

        public void Undo()
        {
            if (_currentCommandIndex >= 0)
            {
                ICommand command = _commandStack[_currentCommandIndex];
                command.Undo();
                _currentCommandIndex--;
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }

        public void Redo()
        {
            if (_currentCommandIndex < _commandStack.Count - 1)
            {
                _currentCommandIndex++;
                ICommand command = _commandStack[_currentCommandIndex];
                command.Execute();
            }
            else
            {
                Console.WriteLine("Nothing to redo.");
            }
        }
    }
}