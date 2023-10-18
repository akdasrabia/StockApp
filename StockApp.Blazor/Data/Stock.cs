using System.ComponentModel.DataAnnotations;

namespace StockApp.Blazor.Data
{
    public class Stock
    {
        public int Id { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
    }
}
