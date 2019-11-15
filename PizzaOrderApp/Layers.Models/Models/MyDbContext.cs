using Layers.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaTut.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
         : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:pizzaserver2019.database.windows.net,1433;Initial Catalog=PizzaDb;Persist Security Info=False;User ID=pizzauser;Password=Pizzaparty2019;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }

        }

        DbSet<Crust> Crusts { get; set; }
        DbSet<Pizza> Pizzas { get; set; }
        DbSet<OrderDetails> OrderDetails { get; set; }
        DbSet<Orders> Orders { get; set; }
        DbSet<Size> Sizes { get; set; }

        DbSet<CustomOrderDetails> CustomOrderDetails { get; set; }

        DbSet<Toppings> Toppings { get; set; }

        DbSet<Customer> Customers { get; set; }

        DbSet<PizzaToppings> PizzaToppings { get; set; }
    }
}
