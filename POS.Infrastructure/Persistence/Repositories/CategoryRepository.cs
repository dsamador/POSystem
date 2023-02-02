using POS.Domain.Entities;
using POS.Infrastructure.Persistence.Contexts;
using POS.Infrastructure.Persistence.Interfaces;

namespace POS.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly POSDBContext _context;

        public CategoryRepository(POSDBContext context)
        {
            _context = context;
        }
    }
}
