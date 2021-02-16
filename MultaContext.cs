using Microsoft.EntityFrameworkCore;
using Tarea_IV_____v.Models;

namespace Tarea_IV_____v
{
    class MultaContext : DbContext
    {
        public DbSet<Infraccion> infracciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionB)
        {
            if (!OptionB.IsConfigured)
            {
                OptionB.UseSqlite("Data Source=DBinfra.db");

            }
        }
    }
}
