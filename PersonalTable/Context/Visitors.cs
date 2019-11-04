using PersonalTable.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonalTable.Context
{
    public class Visitors : DbContext
    {
        public Visitors() : base("Visitors") {
        }
        public DbSet<Visitor> Visitor { get; set; }
    
    }
}