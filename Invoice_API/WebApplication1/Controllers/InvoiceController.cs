
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Repository.Interface;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoices _Invoice;
        public InvoiceController(IInvoices Invoice)
        {
            _Invoice = Invoice;
        }
        [HttpGet]

        [Route("{InvoiceID:int}")]

        public async Task<IActionResult> GetInvoice(int InvoiceID)
        {
            var invoice = await _Invoice.GetInvoiceAsync(InvoiceID);

            if (invoice == null)
                return NotFound("Invoice not found");

            return Ok(invoice);
        }


    }
}
