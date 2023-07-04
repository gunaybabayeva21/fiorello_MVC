using Gul_MVC.Controllers;

namespace Gul_MVC.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageName { get; set; } = null!;
        public int ProductId { get; set; }
        public Prodact prodact { get; set; }
    }
        
}
