using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18._4._1
{
    public class Pult
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public async Task PressButtonAsync()
        {
            if (_command != null)
            {
                await _command.ExecuteAsync();
            }
        }
    }
}
