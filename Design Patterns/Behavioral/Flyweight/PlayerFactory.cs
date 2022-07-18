namespace Design_Patterns.Behavioral.Flyweight
{
    public class PlayerFactory
    {
        public static Dictionary<string, Player> _players = new Dictionary<string, Player>();

        public static Player GetPlayer(string playerType)
        {

            Player? player=_players.GetValueOrDefault(playerType);

            if(player == null)
            {
                if(playerType == typeof(Terrorist).Name)
                {
                    player = new Terrorist();
                    _players.Add(playerType, player);
                }
                
                else if(playerType == typeof(CounterTerrorist).Name)
                {
                    player= new CounterTerrorist();
                    _players.Add(playerType, player);
                }

                return player!;
            }

            return player;
        }
    }
}
