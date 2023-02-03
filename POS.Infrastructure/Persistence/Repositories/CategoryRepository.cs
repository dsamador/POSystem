using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Commons.Bases.Response;
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

        public Task<BaseEntityResponse<Category>> ListCategories(BaseFiltersRequest filters)
        {
            throw new NotImplementedException();
        }

        public Task<Category> CategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditCategory(Category category)
        {
            throw new NotImplementedException();
        }
       
        public Task<IEnumerable<Category>> ListSelectCategories()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
