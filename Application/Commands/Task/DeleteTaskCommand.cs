using MediatR;

namespace Application.Commands.Task
{
    public record DeleteTaskCommand(int Id) : IRequest<bool>;
}
