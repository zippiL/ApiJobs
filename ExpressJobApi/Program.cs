using Job.Core.Repsitories;
using Job.Core.Services;
using Job.Data;
using Job.Data.Repsitories;
using Job.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployerService, EmployerService>();
builder.Services.AddScoped<IWorkService, WorkService>();
builder.Services.AddScoped<IEmployeeRepsitories,EmployeeRepsitories>();
builder.Services.AddScoped<IEmployerRepsitories, EmployerRepsitories>();
builder.Services.AddScoped<IEmployeeRepsitories, EmployeeRepsitories>();
builder.Services.AddScoped<IWorkRepsitories, WorkRepsitories>();

builder.Services.AddDbContext<DataContex>();


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
