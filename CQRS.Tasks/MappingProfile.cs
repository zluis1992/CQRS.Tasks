using AutoMapper;
using Domain;
using Infrastructure.Commands.Task;
using Infrastructure.DTOs;

namespace Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskItem, TaskItemDto>().ReverseMap();
            CreateMap<CreateTaskCommand, TaskItem>().ReverseMap();
        }
    }
}
