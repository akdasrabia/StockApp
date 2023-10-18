using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Dtos
{
    public class StockDto : BaseDto
    {
        public string StockCode { get; set; }
        public string StockName { get; set; }

    }
}
