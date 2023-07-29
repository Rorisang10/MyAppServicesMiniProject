// SupplierController.cs
using Microsoft.AspNetCore.Mvc;
using MyApp.Services_project.Models;

namespace MyApp.Services.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly SupplierService _supplierService;

        public SupplierController(SupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpPost]
        public IActionResult AddSupplier(SupplierDto supplierDto)
        {
            _supplierService.AddSupplier(supplierDto);
            return Ok();
        }

        [HttpGet("{companyName}")]
        public IActionResult GetSupplierByCompanyName(string companyName)
        {
            var supplier = _supplierService.GetSupplierByCompanyName(companyName);
            if (supplier == null)
                return NotFound();

            return Ok(supplier);
        }
    }
}
