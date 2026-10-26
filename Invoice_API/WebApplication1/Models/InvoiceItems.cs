using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    public class InvoiceItems
    {
        [Key]
        public int ItemID { get; set; }
        public int InvoiceID { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }

        [JsonIgnore]
        public Invoices? Invoice { get; set; } = null;
    }
}
