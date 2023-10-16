using Infrastructure.DTOs;
using MediatR;

namespace Application.Queries.Task
{
    public record GetAllTasksQuery : IRequest<IEnumerable<TaskItemDto>>;

}
