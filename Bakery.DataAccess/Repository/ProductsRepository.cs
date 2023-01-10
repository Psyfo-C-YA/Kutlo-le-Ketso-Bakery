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
    public class ProductsRepository : Repository<Product>, IProductsRepository
    {
        private readonly ApplicationDBContext _db;
        
        public ProductsRepository(ApplicationDBContext db) :base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u=>u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Flavor = obj.Flavor;
                objFromDb.Size = obj.Size;
                objFromDb.Price = obj.Price;
                objFromDb.Availability = obj.Availability;
                objFromDb.CategoryId = obj.CategoryId;
            }
            if (obj.ImageUrl != null)
            {
                objFromDb.ImageUrl = obj.ImageUrl;
            }

        }
    }
}
