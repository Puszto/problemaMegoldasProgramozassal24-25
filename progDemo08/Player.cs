using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemo08
{
    public enum Position
    {
        Goalkeeper,
        Forward,
        Winger,
        Defender
    }
    public class Player
    {
        public string Name { get; }
        public Position Pos { get; }

        public Player(string name, Position pos)
        {
            Name = name;
            Pos = pos;
        }

        public override string? ToString()
        {
            return $"Játékos neve: {Name}, Játékos pozíciója: {Pos}";
        }
    }
}
