using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Dtos
{
    public class RecordWithStockDto : RecordDto
    {
        public StockDto Stock { get; set; }
    }
}
