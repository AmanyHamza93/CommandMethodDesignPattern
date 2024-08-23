using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMethodDesignPattern
{
    public class Light
    {
        public void LightOn()
        {
            Console.WriteLine("Light is On");
        }
        public void LightOff()
        {
            Console.WriteLine("Light is Off");
        }
    }
}
