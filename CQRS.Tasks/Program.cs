using Application.Handlers.Task;
using AutoMapper;
using Infrastructure;
using Infrastructure.Commands.Task;
using Infrastructure.Contracts;
using Infrastructure.DataAccessLayer;
using Infrastructure.DTOs;
using Infrastructure.Handler.Task;
using Infrastructure.Queries.Task;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<IRequestHandler<GetAllTasksQuery, IEnumerable<TaskItemDto>>, GetAllTaskHandler>();
builder.Services.AddScoped<IRequestHandler<GetTaskByIdQuery, TaskItemDto?>, GetTaskByIdHandler>();
builder.Services.AddScoped<IRequestHandler<CreateTaskCommand, TaskItemDto>, CreateTaskHandler>();
builder.Services.AddScoped<IRequestHandler<DeleteTaskCommand, bool>, DeleteTaskHandler>();
builder.Services.AddScoped<IRequestHandler<UpdateTaskCommand, TaskItemDto?>, UpdateTaskHandler>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));


//Automapper
var mapperConfig = new MapperConfiguration(mapperConfig =>
    mapperConfig.AddProfile(new MappingProfile()));

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("TaskDB"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
