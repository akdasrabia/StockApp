using AutoMapper;
using StockApp.Core.Dtos;
using StockApp.Core.Entities;
using StockApp.Core.Repositories;
using StockApp.Core.Services;
using StockApp.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Service.Services
{
    public class RecordService : Service<Record>, IRecordService
    {
        private readonly IRecordRepository _recordRepository;
        private readonly IMapper _mapper;

        public RecordService(IGenericRepository<Record> repository, IUnitOfWork unitOfWork, IMapper mapper, IRecordRepository recordRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _recordRepository = recordRepository;
        }
        public async Task<List<RecordWithStockDto>> GetRecordWithStock()
        {
            var records = await _recordRepository.GetRecordsWitStock();

            var recordsDto = _mapper.Map<List<RecordWithStockDto>>(records);
            return recordsDto;
        }
    }
}
