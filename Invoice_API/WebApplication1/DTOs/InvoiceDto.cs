namespace WebApplication1.DTOs
{
    public class InvoiceDto
    {
        public int InvoiceID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public List<InvoiceItemDto> ListItems { get; set; } = new();
    }
}
