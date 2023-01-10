using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.DataAccess.Repository.IRepository
{
    public interface IProductsRepository : IRepository<Product>
    {
        void Update(Product obj);
       
    }
}
