using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication2.Models
{
    public class Studentguru
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; } 
        
    }

    public class StudentGuru2DBcontext: DbContext
    {
        public DbSet<Studentguru> Studentguru {get; set;}

    }
}