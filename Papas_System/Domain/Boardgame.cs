using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papas_System.Domain
{
   public class Boardgame
    {
        public string BoardgameName;
        public int NumberOfPlayers;
        public string Audience;
        public int ExpectedGameTime;
        public string Distributor;
        public int BoardgameId;
        public string GameTag; 

        private Boardgame (string boardgameName,int numberOfPlayers,string audience,int expectedGameTime,string distributor,
        int boardgameId,string gameTag)
        {
            BoardgameName = boardgameName;
            NumberOfPlayers = numberOfPlayers;
            Audience = audience;
            ExpectedGameTime = expectedGameTime;
            Distributor = distributor;
            BoardgameId = boardgameId;
            GameTag = gameTag;
        }


      

    }
}
