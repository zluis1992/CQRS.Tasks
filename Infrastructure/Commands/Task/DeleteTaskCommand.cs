using MediatR;

namespace Infrastructure.Commands.Task
{
    public record DeleteTaskCommand(int Id) : IRequest<bool>;
}
