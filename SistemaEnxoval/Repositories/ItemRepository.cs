using System.ComponentModel.DataAnnotations;

namespace SistemaEnxoval.Repositories
{
    public class ItemRepository
    {
        [Key]
        public int Id { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }

     
    }
}
