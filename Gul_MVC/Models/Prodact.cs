namespace Gul_MVC.Models
{
    public class Prodact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<Catagory> Catagories { get; set; }
    }
}
