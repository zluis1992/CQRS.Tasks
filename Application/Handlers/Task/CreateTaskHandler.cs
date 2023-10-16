using Application.Commands.Task;
using AutoMapper;
using Domain;
using Infrastructure.Contracts;
using Infrastructure.DTOs;
using MediatR;

namespace Application.Handlers.Task
{
    public class CreateTaskHandler : IRequestHandler<CreateTaskCommand, TaskItemDto>
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;
        public CreateTaskHandler(ITaskRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }
        public async Task<TaskItemDto> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var oTask = _mapper.Map<CreateTaskCommand, TaskItemDto>(request);
            return await _taskRepository.Create(oTask, cancellationToken);
        }
    }
}
