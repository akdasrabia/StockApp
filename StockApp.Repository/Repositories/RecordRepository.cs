using Microsoft.EntityFrameworkCore;
using StockApp.Core.Entities;
using StockApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Repository.Repositories
{
    public class RecordRepository : GenericRepository<Record>, IRecordRepository
    {
        public RecordRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Record>> GetRecordsWitStock()
        {
            return await _context.Records.Include(x => x.Stock).ToListAsync();
        }
    }
}
