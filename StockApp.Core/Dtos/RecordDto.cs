using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Dtos
{
    public class RecordDto : BaseDto
    {
        public decimal Cost { get; set; }
        public decimal TotalCost { get; set; }
        public int Amount { get; set; }
        public int StockId { get; set; }
    }
}
