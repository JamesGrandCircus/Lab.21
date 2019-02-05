using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Lab._21.Models.DAL
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("CustomerContext")
        {

        }

        public DbSet<Register> Registers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}