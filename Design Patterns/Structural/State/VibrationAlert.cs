using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.State
{
    public class VibrationAlert : IMobileAlertState
    {
        public void Alert()
        {
            Console.WriteLine("Vibrating...");
        }
    }
}
