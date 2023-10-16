using Application.Commands.Task;
using Infrastructure.Contracts;
using MediatR;

namespace Application.Handlers.Task
{
    public class DeleteTaskHandler : IRequestHandler<DeleteTaskCommand, bool>
    {

        private readonly ITaskRepository _taskRepository;
        public DeleteTaskHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<bool> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            return await _taskRepository.Delete(request.Id, cancellationToken);
        }
    }
}
