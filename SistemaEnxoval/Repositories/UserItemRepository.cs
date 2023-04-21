using System.ComponentModel.DataAnnotations;

namespace SistemaEnxoval.Repositories
{
    public class UserItemRepository
    {
        [Key]
        public int Id { get; set; }
        public int Stock { get; set; } = 0;

        public int UserId { get; set; }
        public int ItemId { get; set; }

        public virtual UserRepository User { get; set; }
        public virtual ItemRepository Item { get; set; }
    }
}
