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
    public class StockRepository : GenericRepository<Stock>, IStockRepository
    {
        public StockRepository(AppDbContext context) : base(context)
        {
        }
    }
}
