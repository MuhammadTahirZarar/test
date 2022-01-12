using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DataDbContext : DbContext //Create db context class and inherit with base class
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) //configure dbContext option 
        {
        }
        public DbSet<Order_table> Order_table { get; set; } // add your data models
    }

}
