using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using global::MyApp.Repository.Data.MyApp.Repository.Data;
using global::MyApp.Repository.Models.MyApp.Repository.Models;
using MyApp.Repository.Data;
using MyApp.Repository.Models;

namespace MyApp.Repository.Repositories
{

    namespace MyApp.Repository.Repositories
    {
        public class SupplierRepository : ISupplierRepository
        {
            private readonly MyAppDbContext _dbContext;

            public SupplierRepository(MyAppDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public void AddSupplier(Supplier supplier)
            {
                _dbContext.Suppliers.Add(supplier);
                _dbContext.SaveChanges();
            }

            public Supplier GetSupplierByCompanyName(string companyName)
            {
                return _dbContext.Suppliers.FirstOrDefault(s => s.CompanyName == companyName);
            }
        }

        public interface ISupplierRepository
        {
        }
    }

}
