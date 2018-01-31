using CST356_Week_3_Lab.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CST356_Week_3_Lab.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}