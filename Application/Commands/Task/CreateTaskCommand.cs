using Infrastructure.DTOs;
using MediatR;

namespace Application.Commands.Task
{
    public record CreateTaskCommand(string Title, string Description) : IRequest<TaskItemDto>;
}
