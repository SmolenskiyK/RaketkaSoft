using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public int Id { get; set; }

        public BaseEntity()
        {
            this.CreateDate = DateTime.Now;
            this.IsActive = true;
        }
    }
}
