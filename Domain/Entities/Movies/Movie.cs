using Domain.Entities.Showtimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Movies
{
    public class Movie : EntityBase<Guid>
    {
        public string Name { get; set; }

    }
}
