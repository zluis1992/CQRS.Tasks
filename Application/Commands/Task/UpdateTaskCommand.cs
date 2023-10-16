using Infrastructure.DTOs;
using MediatR;

namespace Application.Commands.Task
{
    public record UpdateTaskCommand(int Id, string Title, string Description, bool IsCompleted) : IRequest<TaskItemDto?>;
}
