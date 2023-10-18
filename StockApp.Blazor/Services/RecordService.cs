
using Microsoft.EntityFrameworkCore;
using StockApp.Blazor.Data;
using StokApp.Blazor.Context;

namespace StockApp.Blazor.Services
{
    public class RecordService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public RecordService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Record>> GetAllRecords()
        {
            return await _applicationDbContext.Records.ToListAsync();
        }

        public async Task<bool> AddNewEmployee(Record record)
        {
            await _applicationDbContext.Records.AddAsync(record);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Stock>> GetAllStokcs()
        {
            return await _applicationDbContext.Stocks.ToListAsync();
        }


    }
}