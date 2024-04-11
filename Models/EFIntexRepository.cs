
namespace INTEXteam5.Models
{
    public class EFIntexRepository : IIntexRepository
    {
        private Intexteam5Context _context;
        public EFIntexRepository(Intexteam5Context temp) { 
            _context = temp;
        }
        public IQueryable<Order> Orders => _context.Orders;

        public IQueryable<Product> Products => _context.Products;
    }
}

