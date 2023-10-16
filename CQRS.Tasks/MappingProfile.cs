using AutoMapper;
using Domain;
using Application.Commands.Task;
using Infrastructure.DTOs;

namespace Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskItem, TaskItemDto>().ReverseMap();
            CreateMap<CreateTaskCommand, TaskItemDto>();
            CreateMap<UpdateTaskCommand, TaskItemDto>();
        }
    }
}
