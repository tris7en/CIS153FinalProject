using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_Project
{
    class PlayerStats
    {
        private string comWins;
        private string playerWins;
        private string numTies;
        private string numGames;

        public void setComWins(string c)
        {
            comWins = c;
        }

        public void setPlayerWins(string p)
        {
            playerWins = p;
        }

        public void setNumTies(string t)
        {
            numTies = t;
        }

        public void setNumGames(string g)
        {
            numGames = g;
        }

        //=========================================

        public PlayerStats()
        {

        }

        public PlayerStats(string c, string p, string t, string g)
        {
            comWins = c;
            playerWins = p;
            numTies = t;
            numGames = g;
        }

        public string getComWins()
        {
            return comWins;
        }

        public string getPlayerWins()
        {
            return playerWins;
        }

        public string getNumTies()
        {
            return numTies;
        }

        public string getNumGames()
        {
            return numGames;
        }




           
    }
}
