using Bakery.DataAccess.Data;
using Bakery.DataAccess.Repository.IRepository;
using Bakery.Models;
using BulkyBook.DataAccess.Repository;

namespace Bakery.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _db;
        public UnitOfWork(ApplicationDBContext db) 
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Products = new ProductsRepository(_db);
            Company = new CompanyRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);
            OrderDetail = new OrderDetailRepository(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public IProductsRepository Products { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }

        public IApplicationUserRepository ApplicationUser { get; private set; }
        public IOrderHeaderRepository OrderHeader { get; private set; }
        public IOrderDetailRepository OrderDetail { get; private set; }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
