using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Player
    {
        public PersonalInfo PInfo { get; set; }
        public List<MatchResult> Results { get; set; }
    }
}
