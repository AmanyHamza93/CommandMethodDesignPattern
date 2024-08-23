using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMethodDesignPattern
{
    public class RemoteControl
    {
        public void Execute(ICommand command)
        {
            command.Execute();
        }
    }
}
