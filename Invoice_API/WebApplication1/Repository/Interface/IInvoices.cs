using WebApplication1.Models;

namespace WebApplication1.Repository.Interface
{
    public interface IInvoices
    {
        Task<Invoices?> GetInvoiceAsync(int invoiceId);
        Task<IEnumerable<InvoiceItems>> GetAllInvoiceItems();
    }
}
