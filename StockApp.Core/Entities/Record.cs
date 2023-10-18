using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Entities
{
    public class Record : BaseEntity
    {
        public int Amount { get; set; }
        public decimal Cost { get; set; }
        public decimal TotalCost { get; set; }
        public int StockId { get; set; }
        public Stock Stock { get; set; }
    }
}
