using MyApp.Repository.Interfaces;
using MyApp.Services.Models;
using MyApp.Services_project.Models;

namespace MyApp.Services
{
    public class SupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public void AddSupplier(SupplierDto supplierDto)
        {
            var supplier = new Supplier
            {
                CompanyName = supplierDto.CompanyName,
                TelephoneNo = supplierDto.TelephoneNo
            };

            _supplierRepository.AddSupplier(supplier);
        }

        public SupplierDto GetSupplierByCompanyName(string companyName)
        {
            var supplier = _supplierRepository.GetSupplierByCompanyName(companyName);

            if (supplier == null)
                return null;

            return new SupplierDto
            {
                CompanyName = supplier.CompanyName,
                TelephoneNo = supplier.TelephoneNo
            };
        }
    }
}

