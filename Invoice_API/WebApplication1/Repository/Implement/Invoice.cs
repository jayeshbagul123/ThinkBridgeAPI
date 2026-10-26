using Microsoft.EntityFrameworkCore;
using WebApplication1.DBContext;
using WebApplication1.Models;
using WebApplication1.Repository.Interface;

namespace WebApplication1.Repository.Implement
{
    public class Invoice : IInvoices
    {
        private readonly InvoiceDBContext _db;
        public Invoice(InvoiceDBContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<InvoiceItems>> GetAllInvoiceItems()
        {
           return await _db.InvoiceItems.ToListAsync();
        }

        public async Task<Invoices> GetInvoiceAsync(int InvoiceID)
        {
            return await _db.Invoices.Include(o => o.ListItems).FirstOrDefaultAsync( o=> o.InvoiceID == InvoiceID);
        }
    }
}
