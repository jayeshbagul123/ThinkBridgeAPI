using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
using WebApplication1.Models;
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

            var invoiceDto = new InvoiceDto
            {
                InvoiceID = invoice.InvoiceID,
                CustomerName = invoice.CustomerName,
                ListItems = (invoice.ListItems ?? new List<InvoiceItems>())
                    .Select(item => new InvoiceItemDto
                    {
                        ItemID = item.ItemID,
                        InvoiceID = item.InvoiceID,
                        Name = item.name,
                        Price = item.price
                    })
                    .ToList()
            };

            return Ok(invoiceDto);
        }
    }
}
