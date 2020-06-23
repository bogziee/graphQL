using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class BaseballContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("baseballDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().Property(e => e.Position)
                .HasConversion(v => v.ToString(),
                    v => (Position)Enum.Parse(typeof(Position), v));
            base.OnModelCreating(modelBuilder);
        }
    }

    public class Team
    {
        [Required]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string City { get; set; }
        public int LeagueId { get; set; }
    }

    public class League
    {
        [Required]
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
    }

    public class Player
    {
        [Required]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }
        public Position Position { get; set; }
        public DateTime DOB { get; set; }
        public int Weight { get; set; }
        public double Height { get; set; }
    }

    public enum Position
    {
        Pitcher,
        Catcher,
        FirstBase,
        SecondBase,
        ThirdBase,
        ShortStop,
        LeftField,
        CenterField,
        RightField,
        DesignatedHitter
    }
}
