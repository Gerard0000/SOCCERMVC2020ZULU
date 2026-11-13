using Microsoft.EntityFrameworkCore;
using SOCCERMVC2020ZULU.Web.Data.Entities;

namespace SOCCERMVC2020ZULU.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<GroupDetail>? GroupDetails { get; set; }

        public DbSet<Group>? Groups { get; set; }

        public DbSet<Match>? Matches { get; set; }

        public DbSet<Team>? Teams { get; set; }

        public DbSet<Tournament>? Tournaments { get; set; }
    }
}