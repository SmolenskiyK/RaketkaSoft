using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Player : BaseEntity
    {
        public PersonalInfo PersonalInfo { get; set; }
        public List<Match> Results { get; set; }

        public Player()
        {
            this.PersonalInfo = new PersonalInfo();
            this.Results = new List<Match>();
        }
    }
}
