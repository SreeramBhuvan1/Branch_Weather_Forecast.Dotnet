using AutoMapper;
using Task1.Data;
using Task1.dtos.Sampledatadtos;
using Task1.dtos.userdtos;

namespace Task1.Mappers
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<sampledata,SampleDataDtoGet>().ReverseMap();
            CreateMap<sampledata,sampleDataPutDto>().ReverseMap();
            CreateMap<sampledata,SampleDataPostDto>().ReverseMap();
            CreateMap<sampledata,SampleDataGetIdDto>().ReverseMap();
            CreateMap<LoginDto,ApiUser>().ReverseMap();
            CreateMap<ApiUserdto,ApiUser>().ReverseMap();

        }
    }
}
