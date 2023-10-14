using AutoMapper;
using Domain;
using Infrastructure.DTOs;

namespace Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskItem, TaskItemDto>().ReverseMap();
        }
    }
}
