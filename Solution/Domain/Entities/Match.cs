using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Match : BaseEntity
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public List<Tuple<int,int>> GameScores { get; set; } 

        
        public Match()
        {
            this.GameScores = new List<Tuple<int, int>>();
            this.Team1 = new Team();
            this.Team2 = new Team();
        }
    }
}
