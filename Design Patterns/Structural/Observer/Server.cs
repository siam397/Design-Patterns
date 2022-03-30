using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Observer
{
    internal class Server
    {
        IList<Player> players= new List<Player>();
        
        public void add(Player player)
        {
            players.Add(player);
            this.notify();
        }

        public void remove(Player player)
        {
            this.players.Remove(player);
            this.notify();
        }

        public void notify()
        {
            foreach (Player player in players)
            {
                player.serverUpdated(this);
            }
        }

        public int getNumberOfPlayers()
        {
            return players.Count;
        }

    }
}
