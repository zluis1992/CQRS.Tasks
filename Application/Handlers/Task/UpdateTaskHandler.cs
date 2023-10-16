using Application.Commands.Task;
using AutoMapper;
using Infrastructure.Contracts;
using Infrastructure.DTOs;
using MediatR;

namespace Application.Handlers.Task
{

    public class UpdateTaskHandler : IRequestHandler<UpdateTaskCommand, TaskItemDto?>
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;
        public UpdateTaskHandler(ITaskRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<TaskItemDto?> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            return await _taskRepository.Update(_mapper.Map<UpdateTaskCommand, TaskItemDto>(request), cancellationToken);
        }
    }
}
