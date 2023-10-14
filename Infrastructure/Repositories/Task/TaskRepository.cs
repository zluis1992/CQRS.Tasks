using AutoMapper;
using Domain;
using Infrastructure.Commands.Task;
using Infrastructure.Contracts;
using Infrastructure.DataAccessLayer;
using Infrastructure.DTOs;

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

        public Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<TaskItemDto> Update(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var oTask = _mapper.Map<CreateTaskCommand, TaskItem>(request);
            _ctx.TaskItem.Add(oTask);

            await _ctx.SaveChangesAsync(cancellationToken);

            return _mapper.Map<TaskItem, TaskItemDto>(oTask);
        }
    }
}
