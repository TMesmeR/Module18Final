using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18Final.Moduls
{
    internal class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public async Task ExecuteCommandAsync()
        {
            await _command.ExecuteAsync();
        }
    }
}
