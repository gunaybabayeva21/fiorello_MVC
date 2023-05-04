using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Gul_MVC.Models
{
    public class Catagory
    {
        internal object Prodact;

        public int Id { get; set; }
        [Required, MaxLength(25)]
        public string Name { get; set; }
        public List<Prodact>? Prodacts { get; set; }



    }
}
