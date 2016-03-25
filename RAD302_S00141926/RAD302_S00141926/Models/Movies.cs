using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RAD302_S00141926.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public string FilmName { get; set; }
        public string ReleaseYear { get; set; }
        public string Director { get; set; }
    }

    public class MoviesDBContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
    }
}