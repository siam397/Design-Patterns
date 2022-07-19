using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Strategy
{
    public class Player
    {
        private ConsumeItem consumable=new ConsumeItem();
        public void consume()
        {
            consumable.consume(new HealingFlask());
            consumable.consume(new ResurrectionStone());
            consumable.consume(new RedStone());
            consumable.consume(new GreenStone());
        }
        
    }
}
