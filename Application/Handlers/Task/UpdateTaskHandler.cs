using Infrastructure.Commands.Task;
using Infrastructure.Contracts;
using Infrastructure.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers.Task
{

    public class UpdateTaskHandler : IRequestHandler<UpdateTaskCommand, TaskItemDto>
    {
        private readonly ITaskRepository _taskRepository;
        public UpdateTaskHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<TaskItemDto> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            return await _taskRepository.Update(request, cancellationToken);
        }
    }
}
