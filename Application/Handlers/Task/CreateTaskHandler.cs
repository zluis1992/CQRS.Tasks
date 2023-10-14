using Infrastructure.Commands.Task;
using Infrastructure.Contracts;
using Infrastructure.DTOs;
using MediatR;

namespace Application.Handlers.Task
{
    public class CreateTaskHandler : IRequestHandler<CreateTaskCommand, TaskItemDto>
    {
        private readonly ITaskRepository _taskRepository;
        public CreateTaskHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<TaskItemDto> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            return await _taskRepository.Create(request, cancellationToken);
        }
    }
}
