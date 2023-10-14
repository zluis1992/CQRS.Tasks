using Infrastructure.Commands.Task;
using Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contracts
{
    public interface ITaskRepository
    {
        Task<TaskItemDto> Create(CreateTaskCommand request, CancellationToken cancellationToken);
        Task<TaskItemDto> Update(UpdateTaskCommand request, CancellationToken cancellationToken);
        Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
