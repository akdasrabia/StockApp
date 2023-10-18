using StockApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Repositories
{
    public interface IRecordRepository : IGenericRepository<Record>
    {
        Task<List<Record>> GetRecordsWitStock();
    }
}
