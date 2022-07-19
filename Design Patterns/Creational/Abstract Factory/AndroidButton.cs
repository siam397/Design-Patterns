using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Abstract_Factory
{
    public class AndroidButton : IButton
    {
        public void AddButtonClickListener()
        {
            Console.WriteLine("Button clicked on an android device");
        }
    }
}
