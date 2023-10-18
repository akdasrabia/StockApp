using System.ComponentModel.DataAnnotations;

namespace StockApp.Blazor.Data
{
    public class Record
    {
        [Key]
        public int Id { get; set; }
        public Stock Stock { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }

        public int Amount { get; set; }
        [Required]
        public decimal Cost { get; set; }

        [Required] 
        public decimal TotalCost { get; set; }
    }
}
