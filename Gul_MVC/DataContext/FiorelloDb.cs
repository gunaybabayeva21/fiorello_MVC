using Gul_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Gul_MVC.DatabContext
{
    public class FiorelloDb : DbContext
    {

        public FiorelloDb(DbContextOptions<FiorelloDb> options):base(options)
        { 
          
          
        }
        public DbSet<Tag> Tags { get; set; }    
        public DbSet<Catagory> catagory { get; set; }
        public DbSet<Prodact> Prodacts { get; set; }
        public DbSet<Image> images { get; set; }

        public DbSet<Setting> Settings { get; set; }
       
    }
}
