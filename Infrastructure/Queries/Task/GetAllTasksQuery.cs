using Infrastructure.DTOs;
using MediatR;

namespace Infrastructure.Queries.Task
{
    public record GetAllTasksQuery : IRequest<IEnumerable<TaskItemDto>>;

}
