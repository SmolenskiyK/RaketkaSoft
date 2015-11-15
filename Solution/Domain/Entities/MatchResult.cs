using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MatchResult
    {
        public List<Player> Team1 { get; set; }
        public List<Player> Team2 { get; set; }
        public List<int> GameScores { get; set; } //Team1 did loss game if score less then 0
        public bool IsTeam1Win 
        { 
            get
            {
                int winsCount = 0;
                foreach (var item in GameScores)
                {
                    if (item>0)
                    {
                        winsCount++;
                    }
                    else
                    {
                        winsCount--;
                    }
                }
                return winsCount > 0;
            } 
        }
        
        public MatchResult()
        {
            this.GameScores = new List<int>();
        }
    }
}
