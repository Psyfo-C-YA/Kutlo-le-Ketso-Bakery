using Bakery.DataAccess.Data;
using Bakery.DataAccess.Repository;
using Bakery.DataAccess.Repository.IRepository;
using Bakery.Models;

namespace Bakery.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDBContext _db;

        public ApplicationUserRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }

    }
}
