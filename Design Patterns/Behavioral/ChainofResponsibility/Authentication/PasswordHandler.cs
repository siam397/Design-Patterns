using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.ChainofResponsibility.Authentication
{
    public class PasswordHandler : AuthHandler
    {
        public override void Handle(string username, string password)
        {
            if(password == _dummyCorrectPassword)
            {
                Console.WriteLine("YOU ARE NOW LOGGED IN");
                return;
            }

            Console.WriteLine("Password didn't match");

        }
    }
}
