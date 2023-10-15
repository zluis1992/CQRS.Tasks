using Infrastructure.DTOs;
using MediatR;

namespace Infrastructure.Commands.Task
{
    public record UpdateTaskCommand(int Id, string Title, string Description, bool IsCompleted) : IRequest<TaskItemDto?>;
}
