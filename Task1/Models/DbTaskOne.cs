using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class DbTaskOne:DbContext
    {

        public DbTaskOne(DbContextOptions<DbTaskOne> options) : base(options)
        {

        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Property> Properties { get; set; }
    }
}
