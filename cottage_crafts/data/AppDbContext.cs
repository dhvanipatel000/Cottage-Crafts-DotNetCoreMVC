using cottage_crafts.Models;
using cottage_crafts.Models.Account;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cottage_crafts.data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Crafts> Crafts { get; set; }

        // public DbSet<Crafts> Crafts { get; set; }
        //public DbSet<cottage_crafts.Models.Crafts.CraftsViewModel> CraftsViewModel { get; set; }
        //public DbSet<cottage_crafts.Models.Crafts.Crafts> Crafts_1 { get; set; }

        //order related tables
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
        //public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
