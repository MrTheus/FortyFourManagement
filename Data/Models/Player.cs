using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortyFourManagement.Data.Models
{
    public  class Player
    {
        public Int32 PlayerID { get; set; }

        /// <summary>
        /// Name of the Player
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Url for the Player
        /// </summary>
        public String PlayerUrl { get; set; }

        /// <summary>
        /// The image url of the player
        /// </summary>
        public String ImageUrl { get; set; }

        /// <summary>
        /// The player position
        /// </summary>
        public String Position { get; set; }

        /// <summary>
        /// The player number
        /// </summary>
        public String Number { get; set; }

        /// <summary>
        /// The birth date of the player
        /// </summary>
        public String BirthDate { get; set; }

        /// <summary>
        /// The market value of the player
        /// </summary>
        public String MarketValue { get; set; }

        /// <summary>
        /// Indicates if the player is the captain
        /// </summary>
        public Boolean IsCaptain { get; set; }

        public Boolean Loaned { get; set; }

        public Boolean IsNew { get; set; }

        public Models.Team Team { get; set; }
        public UsedPlayer Used { get; set; }

    }
}
