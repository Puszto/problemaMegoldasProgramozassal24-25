using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemo08
{
    public class Team
    {

        public Player[] _players;
        int _numbOfPlayers;
        public bool IsFull
        {
            get
            {
                return _numbOfPlayers == 5; 
            }
        }

        public bool IsIncluded(Player player)
        {
            if (_numbOfPlayers == 0)
            {
                return false;
            }

            else
            {
                for (int i = 0; i < _players.Length; i++)
                {
                    if (_players[i] == player)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsAvailable(Player player)
        {
            if (_numbOfPlayers == 0)
            {
                return true;
            }

            else
            {
                Position localPosition = player.Pos;

                int goalkeeperCount = 0;
                int defenderCount = 0;
                int wingerCount = 0;
                int forwardCount = 0;

                for (int i = 0; i < _numbOfPlayers; i++)
                {
                    if (_players[i].Pos == player.Pos && _players[i].Pos == Position.Goalkeeper)
                    {
                        return false;
                    }

                    if (_players[i].Pos == player.Pos && _players[i].Pos == Position.Defender)
                    {
                        return false;
                    }

                    if (_players[i].Pos == player.Pos && _players[i].Pos == Position.Winger)
                    {
                        wingerCount++;
                        if (wingerCount > 1)
                        {
                            return false;
                        }
                    }

                    if (_players[i].Pos == player.Pos && _players[i].Pos == Position.Forward)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public void Include(Player player)
        {
            if (IsAvailable(player) && !IsFull)
            {
                _players[_numbOfPlayers] = player;
                _numbOfPlayers++;
                Console.WriteLine($"\t---> \"{player.Name}\" sikeresen fel lett véve a csapatba.");
            }

            else
            {
                Console.WriteLine($"\t---> HIBA: {player.ToString()} játékos nem adható hozzá, mivel erre a pozícióra nem vehető már föl plusz játékos.");
            }
        }

        public Team(int meret)
        {
            _players = new Player[meret];
            _numbOfPlayers = 0;
        }
    }
}
