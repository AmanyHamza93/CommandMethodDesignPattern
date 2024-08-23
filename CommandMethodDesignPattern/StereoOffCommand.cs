using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMethodDesignPattern
{
    public class StereoOffCommand : ICommand
    {
        public readonly Stereo _stereo;
        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.StereoOff();
        }
    }
}
