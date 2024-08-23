using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMethodDesignPattern
{
    public class LightOnCommand : ICommand
    {
        public readonly Light _light;
        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.LightOn();
        }
    }
}
