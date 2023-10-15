using Infrastructure.Commands.Task;
using Infrastructure.DTOs;

namespace Infrastructure.Contracts
{
    public interface ITaskRepository
    {
        Task<TaskItemDto> Create(CreateTaskCommand request, CancellationToken cancellationToken);
        Task<IEnumerable<TaskItemDto>> GetAll(CancellationToken cancellationToken);
        Task<TaskItemDto?> GetById(int Id, CancellationToken cancellationToken);
        Task<TaskItemDto?> Update(UpdateTaskCommand request, CancellationToken cancellationToken);
        Task<bool> Delete(int Id, CancellationToken cancellationToken);
    }
}
