using Data;
using System;

namespace MockData
{
    public static class GenerateData
    {
        public static void Generate()
        {
            using(var db = new BaseballContext())
            {
                db.Add<League>(new League { LeagueId = 1, LeagueName = "AL East" });
                db.Add<League>(new League { LeagueId = 2, LeagueName = "AL Central" });
                db.Add<League>(new League { LeagueId = 3, LeagueName = "AL West" });
                db.Add<League>(new League { LeagueId = 4, LeagueName = "NL East" });
                db.Add<League>(new League { LeagueId = 5, LeagueName = "NL Central" });
                db.Add<League>(new League { LeagueId = 6, LeagueName = "NL West" });

                db.Add<Team>(new Team { TeamId = 1, City = "Toronto", TeamName = "Blue Jays", LeagueId = 1 });
                db.Add<Team>(new Team { TeamId = 2, City = "New York", TeamName = "Yankees", LeagueId = 1 });
                db.Add<Team>(new Team { TeamId = 3, City = "Baltimore", TeamName = "Orioles", LeagueId = 1 });
                db.Add<Team>(new Team { TeamId = 4, City = "Boston", TeamName = "Red Sox", LeagueId = 1 });
                db.Add<Team>(new Team { TeamId = 5, City = "Tampa Bay", TeamName = "Rays", LeagueId = 1 });

                db.Add<Team>(new Team { TeamId = 6, City = "Chicago", TeamName = "White Sox", LeagueId = 2 });
                db.Add<Team>(new Team { TeamId = 7, City = "Los Angeles", TeamName = "Angels", LeagueId = 3 });
                db.Add<Team>(new Team { TeamId = 8, City = "Oakland", TeamName = "Ahtletics", LeagueId = 3 });
                db.Add<Team>(new Team { TeamId = 9, City = "Atlanta", TeamName = "Braves", LeagueId = 4 });
                db.Add<Team>(new Team { TeamId = 10, City = "San Francisco", TeamName = "Giants", LeagueId = 6 });

                db.Add<Player>(new Player { PlayerId = 1, Name = "Danny Jansen", DOB = new DateTime(1995, 4, 15), Height = 6.2, Position = Position.Catcher, Weight = 230, TeamId = 1 });
                db.Add<Player>(new Player { PlayerId = 2, Name = "Bo Bichette", DOB = new DateTime(1998, 3, 5), Height = 6.0, Position = Position.ShortStop, Weight = 185, TeamId = 1 });
                db.Add<Player>(new Player { PlayerId = 3, Name = "Randal Grichuk", DOB = new DateTime(1991, 8, 13), Height = 6.2, Position = Position.CenterField, Weight = 213, TeamId = 1 });
                db.Add<Player>(new Player { PlayerId = 4, Name = "Vlady", DOB = new DateTime(1999, 3, 16), Height = 6.2, Position = Position.ThirdBase, Weight = 250, TeamId = 1 });
                db.Add<Player>(new Player { PlayerId = 5, Name = "J.A. Happ", DOB = new DateTime(1982, 10, 19), Height = 6.5, Position = Position.Pitcher, Weight = 205, TeamId = 2 });
                db.Add<Player>(new Player { PlayerId = 7, Name = "Aaron Judge", DOB = new DateTime(1992, 4, 26), Height = 6.7, Position = Position.RightField, Weight = 282, TeamId = 2 });
                db.Add<Player>(new Player { PlayerId = 8, Name = "Kevin Pillar", DOB = new DateTime(1989, 4, 1), Height = 6.0, Position = Position.CenterField, Weight = 210, TeamId = 4 });
                db.Add<Player>(new Player { PlayerId = 9, Name = "Edwin Encarnacion", DOB = new DateTime(1983, 1, 17), Height = 6.1, Position = Position.FirstBase, Weight = 230, TeamId = 6 });
                db.Add<Player>(new Player { PlayerId = 10, Name = "Mike Trout", DOB = new DateTime(1991, 8, 7), Height = 6.2, Position = Position.CenterField, Weight = 235, TeamId = 7 });
                db.Add<Player>(new Player { PlayerId = 11, Name = "Alber Pujols", DOB = new DateTime(1980, 1, 16), Height = 6.3, Position = Position.FirstBase, Weight = 235, TeamId = 7 });
                db.Add<Player>(new Player { PlayerId = 12, Name = "Shohei Ohtani", DOB = new DateTime(1994, 7, 5), Height = 6.4, Position = Position.DesignatedHitter, Weight = 210, TeamId = 7 });
                db.Add<Player>(new Player { PlayerId = 13, Name = "A.J. Puk", DOB = new DateTime(1995, 4, 25), Height = 6.7, Position = Position.Pitcher, Weight = 238, TeamId = 8 });
                db.Add<Player>(new Player { PlayerId = 14, Name = "Sean Murphy", DOB = new DateTime(1994, 10, 4), Height = 6.3, Position = Position.Catcher, Weight = 232, TeamId = 8 });
                db.Add<Player>(new Player { PlayerId = 15, Name = "Ronald Acuna Jr.", DOB = new DateTime(1997, 12, 18), Height = 6.0, Position = Position.LeftField, Weight = 205, TeamId = 9 });
                db.Add<Player>(new Player { PlayerId = 16, Name = "Mike Foltynewicz", DOB = new DateTime(1991, 10, 7), Height = 6.4, Position = Position.Pitcher, Weight = 195, TeamId = 9 });
                db.Add<Player>(new Player { PlayerId = 17, Name = "Chris Shaw", DOB = new DateTime(1993, 10, 20), Height = 6.3, Position = Position.RightField, Weight = 226, TeamId = 10 });
                db.Add<Player>(new Player { PlayerId = 18, Name = "Trevor Gott", DOB = new DateTime(1992, 8, 26), Height = 6.0, Position = Position.Pitcher, Weight = 185, TeamId = 10 });
                db.Add<Player>(new Player { PlayerId = 19, Name = "DJ Stewart", DOB = new DateTime(1993, 11, 30), Height = 6.0, Position = Position.RightField, Weight = 230, TeamId = 3 });
                db.Add<Player>(new Player { PlayerId = 6, Name = "Austin Meadows", DOB = new DateTime(1995, 5, 3), Height = 6.3, Position = Position.RightField, Weight = 220, TeamId = 5 });
                db.Add<Player>(new Player { PlayerId = 20, Name = "Shun Yamaguchi", DOB = new DateTime(1987, 7, 11), Height = 6.2, Position = Position.Pitcher, Weight = 198, TeamId = 1 });

                db.SaveChanges();
            }
        }
    }
}
