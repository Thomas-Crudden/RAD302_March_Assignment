using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace S00141926_RAD302_Assignment.Models
{
    public class Characters
    {
        public int ID { get; set;}
        public string Name { get; set; }
        public string Actor { get; set; }

    }

    public class CharactersDBContext : DbContext
    {
        public DbSet<Characters> Characters { get; set; }
    }
}