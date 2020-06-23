using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MockData;
using System;
using System.Linq;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateData.Generate();
            using var db = new BaseballContext();
            Console.WriteLine("Teams:");
            db.Teams.ForEachAsync(x => Console.WriteLine($"{x.TeamName} - {x.City}"));

            Console.WriteLine("\nPlayers:");
            var query = db.Players.Join(db.Teams,
                p => p.TeamId,
                t => t.TeamId,
                (p, t) => new
                {
                    Name = p.Name,
                    Team = t.TeamName
                }).ToList();
            query.ForEach(x => Console.WriteLine($"{x.Name} - {x.Team}"));

            Console.ReadKey(true);
        }
    }
}
