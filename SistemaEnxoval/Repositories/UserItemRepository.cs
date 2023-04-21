namespace SistemaEnxoval.Repositories
{
    public class UserItemRepository
    {
        public int Id { get; set; }
        public int Stock { get; set; } = 0; 
        public virtual UserRepository User { get; set; }
        public virtual ItemRepository Items { get; set; }
    }
}
