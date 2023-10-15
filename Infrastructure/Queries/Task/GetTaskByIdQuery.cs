using Infrastructure.DTOs;
using MediatR;

namespace Infrastructure.Queries.Task
{
    public record GetTaskByIdQuery(int Id) : IRequest<TaskItemDto?>;
}
