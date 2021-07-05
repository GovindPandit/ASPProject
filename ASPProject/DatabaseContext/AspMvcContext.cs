using ASPProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPProject.DatabaseContext
{
    public class AspMvcContext : DbContext
    {
        public AspMvcContext() : base("ASPProjectContext")
        {

        }

        public DbSet<User> users { get; set; }
    }
}