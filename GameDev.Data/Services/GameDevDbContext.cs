using GameDev.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev.Data.Services
{
    public class GameDevDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
    }
}
