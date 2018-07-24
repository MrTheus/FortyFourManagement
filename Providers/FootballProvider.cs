using FortyFourManagement.Data;
using FortyFourManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortyFourManagement.Providers
{
    public class FootballProvider
    {
        public List<Team> GetTeams()
        {
            using(var ctx = new FootballDataContext())
            {
                return ctx.Teams.ToList();
            }
        }

        public void Add(Team team)
        {
            using (var ctx = new FootballDataContext())
            {
                ctx.Teams.Add(team);

                ctx.SaveChanges();
            }
        }

        public async Task Update(Team team)
        {
            using (var ctx = new FootballDataContext())
            {
               var existing = ctx.Teams.FirstOrDefault(c => c.TeamId == team.TeamId);
                if(existing != null)
                {
                    existing = team;

                    await ctx.SaveChangesAsync();
                }

            }
        }

        public async Task Delete(Team team)
        {
            using(var ctx = new FootballDataContext())
            {
                var existing = ctx.Teams.FirstOrDefault(c => c.TeamId == team.TeamId);
                if(existing != null)
                {
                    ctx.Teams.Remove(existing);
                    await ctx.SaveChangesAsync();
                }
            }
        }

    }
}
