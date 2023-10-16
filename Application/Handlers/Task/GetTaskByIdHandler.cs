using Infrastructure.Contracts;
using Infrastructure.DTOs;
using Application.Queries.Task;
using MediatR;

namespace Application.Handlers.Task
{
    public class GetTaskByIdHandler : IRequestHandler<GetTaskByIdQuery, TaskItemDto?>
    {
        private readonly ITaskRepository _taskRepository;
        public GetTaskByIdHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<TaskItemDto?> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            return await _taskRepository.GetById(request.Id, cancellationToken);
        }
    }
}
