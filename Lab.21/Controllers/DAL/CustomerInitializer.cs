using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab._21.Models.DAL
{
    public class CustomerInitializer : System.Data.Entity.CreateDatabaseIfNotExists<CustomerContext>
    {

        protected override void Seed(CustomerContext context)
        {
            var customer = new List<Register>
            {
                new Register{FirstName = "Zachary", LastName = "Hordynski", Email = "crazyfrog08@hotmail.com", PhoneNumber = "3133133113", Password = "psytrance"}
            };

            customer.ForEach(s => context.Registers.Add(s));
            context.SaveChanges();
        }

    }
}