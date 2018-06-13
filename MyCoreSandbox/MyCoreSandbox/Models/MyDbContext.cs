using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreSandbox.Models
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> option) : base(option)
        {
            Database.EnsureCreated();
        }

        
        public DbSet<Vessel> Vessels { get; set; }


    }
}
