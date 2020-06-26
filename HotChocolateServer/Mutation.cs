using Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HotChocolateServer
{
    public class Mutation
    {
        public async Task<Player> AddPlayer(string name, int teamId, string position, double height, int weight)
        {
            var db = new BaseballContext();
            Player player = new Player
            {
                PlayerId = db.Players.Select(x => x.PlayerId).Max() + 1,
                Name = name,
                TeamId = teamId,
                Position = (Position)Enum.Parse(typeof(Position), position),
                Height = height,
                Weight = weight
            };
            db.Players.Add(player);
            db.SaveChanges();
            return player;
        }
    }
}