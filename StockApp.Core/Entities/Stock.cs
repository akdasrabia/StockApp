using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Entities
{
    public class Stock : BaseEntity
    {
        public string StockCode { get; set; }
        public string StockName { get; set; }
    }
}
