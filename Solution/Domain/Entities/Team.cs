using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Team : BaseEntity
    {
        HashSet<Player> Team { get; set; }
        public string  Name{ get; set; }     
  
        public Team()
        {
            this.Team = new HashSet<Player>();
            this.Name = String.Empty;
        }
    }
}
