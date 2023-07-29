using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ISupplierRepository.cs
using MyApp.Repository.Models;
using MyApp.Repository.Models.MyApp.Repository.Models;

namespace MyApp.Repository.Interfaces
{
    public interface ISupplierRepository
    {
        void AddSupplier(Supplier supplier);
        Supplier GetSupplierByCompanyName(string companyName);
    }
}

