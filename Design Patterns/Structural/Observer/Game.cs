using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Observer
{
    public class Game
    {
        public void gameRunning()
        {
            Server server= new Server();
            server.add(new Player("ashenOne"));
            server.add(new Player("ape"));
            server.add(new Player("himel"));
        }
    }
}
