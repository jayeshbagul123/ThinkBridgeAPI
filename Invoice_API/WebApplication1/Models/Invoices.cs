using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Invoices
    {
        [Key]
        public int InvoiceID { get; set; }
        public string CustomerName { get; set; }

        public List<InvoiceItems> ListItems { get; set; } = new();
    }
}
