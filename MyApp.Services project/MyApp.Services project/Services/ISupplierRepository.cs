// SupplierService.cs
namespace MyApp.Services
{
    internal interface ISupplierRepository
    {
        void AddSupplier(Supplier supplier);
        object GetSupplierByCompanyName(string companyName);
    }
}