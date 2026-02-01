using ChicoFood.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChicoFood.Data
{
    public class ChicoFoodDbContext : DbContext
    {
        public ChicoFoodDbContext(DbContextOptions<ChicoFoodDbContext> options) : base(options)
        {
            
        }
         public DbSet<Restaurant> Restaurants { get; set; }
    }
}
