using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papas_System.Domain
{
   public class Boardgame
    {
        public string BoardgameName { get; set; }
        public int NumberOfPlayers { get; set; }
        public string Audience { get; set; }
        public int ExpectedGameTime { get; set; }
        public string Distributor { get; set; }
        public int BoardgameId { get; set; }
        public string GameTag { get; set; }

    }
}
