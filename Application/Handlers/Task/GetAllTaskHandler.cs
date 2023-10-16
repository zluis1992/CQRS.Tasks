using Infrastructure.Contracts;
using Infrastructure.DTOs;
using Application.Queries.Task;
using MediatR;

namespace Application.Handlers.Task
{
    public class GetAllTaskHandler : IRequestHandler<GetAllTasksQuery, IEnumerable<TaskItemDto>>
    {
        private readonly ITaskRepository _taskRepository;
        public GetAllTaskHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<IEnumerable<TaskItemDto>> Handle(GetAllTasksQuery request, CancellationToken cancellationToken)
        {
            return await _taskRepository.GetAll(cancellationToken);
        }
    }
}
