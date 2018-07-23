using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortyFourManagement.Data.Models
{
    public class Team
    {
        public Int32 TeamId { get; set; }

        public String Name { get; set; }

        public String TeamUrl { get; set; }

        public String TeamPlayersUrl { get; set; }

        public String PlayerCount { get; set; }

        public String MarketValue { get; set; }

        public String MarketValueMedian { get; set; }

        public String Icon { get; set; }

        public League League { get; set; }
    }
}
