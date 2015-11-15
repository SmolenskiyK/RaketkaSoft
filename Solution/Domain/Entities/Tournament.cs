using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Tournament
    {
        public List<Player> Players { get; set; }

        public Tournament()
        {
            this.Players = new List<Player>();
        }
    }
}
