using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortyFourManagement.Data.Models
{
    public class UsedPlayer
    {
        public Int32 UsedPlayerID { get; set; }
        public Boolean PlayerUsed { get; set; }
        public Int32 PlayerID { get; set; }
    }
}
