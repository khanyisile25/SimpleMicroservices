using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Database.Entities
{
    public class DatabaseContext: DbContext
    {
        public DbSet <User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5C1CT7F;Initial Catalog=UserMicroservice;Integrated Security=True");
        }
    }
}
 