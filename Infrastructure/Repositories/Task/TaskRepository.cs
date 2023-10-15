using AutoMapper;
using Domain;
using Infrastructure.Commands.Task;
using Infrastructure.Contracts;
using Infrastructure.DataAccessLayer;
using Infrastructure.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Handler.Task
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _ctx;
        private readonly IMapper _mapper;

        public TaskRepository(IMapper mapper, ApplicationDbContext applicationDbContext)
        {
            _ctx = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<TaskItemDto> Create(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var oTask = _mapper.Map<CreateTaskCommand, TaskItem>(request);
            _ctx.TaskItem.Add(oTask);

            await _ctx.SaveChangesAsync(cancellationToken);

            return _mapper.Map<TaskItem, TaskItemDto>(oTask);
        }

        public async Task<bool> Delete(int Id, CancellationToken cancellationToken)
        {
            var oTaskItem = await _ctx.TaskItem.FindAsync(Id, cancellationToken);

            if (oTaskItem == null)
            {
                return false;
            }

            _ctx.TaskItem.Remove(oTaskItem);
            await _ctx.SaveChangesAsync(cancellationToken);

            return true;
        }

        public async Task<IEnumerable<TaskItemDto>> GetAll(CancellationToken cancellationToken)
        {
            return _mapper.Map<IEnumerable<TaskItem>, IEnumerable<TaskItemDto>>(await _ctx.TaskItem.ToListAsync(cancellationToken));
        }

        public async Task<TaskItemDto?> GetById(int Id, CancellationToken cancellationToken)
        {
            var oTaskItem = await _ctx.TaskItem.FindAsync(Id, cancellationToken);
            if (oTaskItem == null)
            {
                return null;
            }

            return _mapper.Map<TaskItem, TaskItemDto>(oTaskItem);
        }

        public async Task<TaskItemDto?> Update(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var oTaskItem = await _ctx.TaskItem.FindAsync(request.Id, cancellationToken);

            if (oTaskItem == null)
            {
                return null;
            }

            oTaskItem.Title = request.Title;
            oTaskItem.Description = request.Description;
            oTaskItem.IsCompleted = request.IsCompleted;

            await _ctx.SaveChangesAsync(cancellationToken);
            return _mapper.Map<TaskItem, TaskItemDto>(oTaskItem);
        }


    }
}
