using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    public class OrderingSystemContext : DbContext
    {
        public OrderingSystemContext(DbContextOptions<OrderingSystemContext> options) : base(options)
        {

        }

        public OrderingSystemContext()
        {

        }

        public DbSet<User_Registration> User_Registration { get; set; }
        public DbSet<Product_Details> Product_Details { get; set; }
        public DbSet<Category_Detail> Category_Detail { get; set; }
        public DbSet<Sub_Category_Details> Sub_Category_Details { get; set; }
    }
}
