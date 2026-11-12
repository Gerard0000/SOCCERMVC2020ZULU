using Microsoft.EntityFrameworkCore;
using SOCCERMVC2020ZULU.Web.Data.Entities;

namespace SOCCERMVC2020ZULU.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<TeamEntity> Team { get; set; }
    }
}