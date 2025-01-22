using Microsoft.EntityFrameworkCore;
using Project1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Persistence.Context
{
    public class Project1DbContext : DbContext
    {
        public Project1DbContext(DbContextOptions<Project1DbContext> options)
            : base(options) 
        { 
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Item> Items { get; set; }  
        

    }
}
