using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace WebApplication2.Models
{
    public class MSContext : DbContext
    {
      public DbSet<MS_TBL> MS_TBLs { get; set; }
        public DbSet<TITLE_NAME> TITLE_NAMEs { get; set; }
    }
}