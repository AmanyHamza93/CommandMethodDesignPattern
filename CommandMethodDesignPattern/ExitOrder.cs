using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMethodDesignPattern
{
    public class ExitOrder : IExecute
    {
        public string Command()
        {
            return "exit";
        }
    }
}
