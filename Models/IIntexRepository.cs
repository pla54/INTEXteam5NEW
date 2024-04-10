namespace INTEXteam5.Models
{
    public interface IIntexRepository
    {
        public IQueryable<Order> Orders { get; }
    }
}
