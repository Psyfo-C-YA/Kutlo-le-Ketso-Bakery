using Bakery.DataAccess.Data;
using Bakery.DataAccess.Repository.IRepository;
using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDBContext _db;
        
        public CompanyRepository(ApplicationDBContext db) :base(db)
        {
            _db = db;
        }
         
        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
