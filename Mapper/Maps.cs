using AutoMapper;
using Eaigle.SmokeEvent.API.Dto;
using Eaigle.SmokeEvent.API.Model;

namespace Eaigle.SmokeEvent.API.Mapper;

public class Maps : Profile
{
    public Maps()
    {
        CreateMap<TbSmokeEvent, SmokeEventDto>().ReverseMap();
    }
}