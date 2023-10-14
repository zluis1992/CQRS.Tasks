using Infrastructure.DTOs;
using MediatR;

namespace Infrastructure.Commands.Task
{
    public record CreateTaskCommand(string Title, string Description) : IRequest<TaskItemDto>;
}
