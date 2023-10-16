using Infrastructure.DTOs;
using MediatR;

namespace Application.Queries.Task
{
    public record GetTaskByIdQuery(int Id) : IRequest<TaskItemDto?>;
}
