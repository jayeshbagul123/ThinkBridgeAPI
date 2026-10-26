
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DBContext
{
    public class InvoiceDBContext : DbContext
    {
        public InvoiceDBContext(DbContextOptions<InvoiceDBContext> options)
            : base(options)
        {
        }

        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<InvoiceItems> InvoiceItems { get; set; }
    }
}
   