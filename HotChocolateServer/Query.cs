using Data;
using System.Collections.Generic;
using System.Linq;

namespace HotChocolateServer
{
    public class Query
    {
        public List<Team> Teams
        {
            get
            {
                using var db = new BaseballContext();
                return db.Teams.ToList();
            }
        }
        public List<League> Leagues { 
            get
            {
                using var db = new BaseballContext();
                return db.Leagues.ToList();
            }
        }

        public List<Player> Players
        {
            get
            {
                using var db = new BaseballContext();
                return db.Players.ToList();
            }
        }

        public List<Player> GetPlayers(int? teamId)
        {
            return teamId == null ? this.Players : this.Players.Where(x => x.TeamId == teamId).ToList();
        }
    }
}