using StockApp.Core.Dtos;
using StockApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Services
{
    public interface IRecordService : IService<Record>
    {
        Task<List<RecordWithStockDto>> GetRecordWithStock();
    }
}
