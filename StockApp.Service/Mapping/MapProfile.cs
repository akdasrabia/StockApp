using AutoMapper;
using StockApp.Core.Dtos;
using StockApp.Core.Entities;


namespace StockApp.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Record, RecordDto>().ReverseMap();
            CreateMap<Stock, StockDto>().ReverseMap();
            CreateMap<Stock, RecordWithStockDto>().ReverseMap();
        }
    }
}
