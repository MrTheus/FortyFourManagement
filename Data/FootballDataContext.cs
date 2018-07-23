using FortyFourManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortyFourManagement.Data
{
    public class FootballDataContext : DbContext
    {
        public DbSet<Models.Team> Teams { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Models.Player> Players { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<UsedPlayer> UsedPlayers { get; set; }

        public FootballDataContext() : base(ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString)
        {

        }

        public FootballDataContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }
    }
}
