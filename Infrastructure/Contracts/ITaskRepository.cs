using Infrastructure.DTOs;

namespace Infrastructure.Contracts
{
    public interface ITaskRepository
    {
        Task<TaskItemDto> Create(TaskItemDto TaskItem, CancellationToken cancellationToken);
        Task<IEnumerable<TaskItemDto>> GetAll(CancellationToken cancellationToken);
        Task<TaskItemDto?> GetById(int Id, CancellationToken cancellationToken);
        Task<TaskItemDto?> Update(TaskItemDto TaskItem, CancellationToken cancellationToken);
        Task<bool> Delete(int Id, CancellationToken cancellationToken);
    }
}
