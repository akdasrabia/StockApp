using AutoMapper;
using StockApp.Core.Entities;
using StockApp.Core.Repositories;
using StockApp.Core.Services;
using StockApp.Core.UnitOfWorks;

namespace StockApp.Service.Services
{
    public class StockService : Service<Stock>, IStockService
    {
        private readonly IStockRepository _stockRepository;
        private readonly IMapper _mapper;

        public StockService(IGenericRepository<Stock> repository, IUnitOfWork unitOfWork, IMapper mapper, IStockRepository stockRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _stockRepository = stockRepository;
        }
    }
}
