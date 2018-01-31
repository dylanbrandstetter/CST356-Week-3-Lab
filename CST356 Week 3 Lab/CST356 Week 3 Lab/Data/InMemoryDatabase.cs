using CST356_Week_3_Lab.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CST356_Week_3_Lab.Data
{
    public static class InMemoryDatabase
    {
        public static ICollection<User> Users = new List<User>();
    }
}