using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Tournament : BaseEntity
    {
        public List<Team> Competitors { get; set; }
        public string Name { get; set; }

        public Tournament()
        {
            this.Competitors = new List<Team>();
            this.Name = String.Empty;
        }
    }
}
