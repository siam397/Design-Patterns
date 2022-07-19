using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.ChainofResponsibility.Authentication
{
    public class ValidateUsername : AuthHandler
    {
        public override void Handle(string username, string password)
        {
            if (username == _dummyCorrectUsername)
            {
                Console.WriteLine("Correct username. Checking password...");
                GoToNextHandler(username, password);
                return;
            }
            Console.WriteLine("WRONG USERNAME");
        }
    }
}
