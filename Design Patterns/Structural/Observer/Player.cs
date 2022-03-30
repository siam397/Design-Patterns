using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Observer
{
    internal class Player
    {
        private string username;
        public Player(string username)
        {
            this.username = username;
        }
        public void serverUpdated(Server server)
        {
            Console.WriteLine($"Number of active players {server.getNumberOfPlayers()}");
        }
    }
}
