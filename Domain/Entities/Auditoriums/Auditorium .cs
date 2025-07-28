using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Auditoriums
{
    public class Auditorium : EntityBase<Guid>
    {
        public string Name { get;  set; }
        public int Capacity { get;  set; }
    }
}
