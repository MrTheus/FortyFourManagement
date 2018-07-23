using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortyFourManagement.Data.Models
{
    public class League
    {
        public Int32 LeagueId { get; set; }

        public String Name { get; set; }
        public Country Country { get; set; }
    }
}
