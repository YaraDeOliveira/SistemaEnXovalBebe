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

        public ICollection<UserRepository> Users { get; set; }

        public ItemRepository(string product, int quantity, string size)
        {
            Product = product;
            Quantity = quantity;
            Size = size;
        }
    }
}
