using Garage_Management.BAL.Implementation;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IUserManagement, UserManagement>();
builder.Services.AddTransient<IVehicle, VehicleManagement>();
builder.Services.AddTransient<IGarage, GarageManagement>();
builder.Services.AddTransient<IDailyWorkSummary, DailyWorkManagement>();
builder.Services.AddTransient<IAuthentication, Authentication>();
builder.Services.AddTransient<ICounts, CountManagement>();
builder.Services.AddTransient<IEmployee,EmployeeManagement>();
builder.Services.AddTransient<IReminder, Reminders>();
builder.Services.AddTransient<ICurrentAsignee, CurrentAssignees>();
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
app.UseCors(options =>
{
    options.WithOrigins("http://localhost:4200")
           .AllowAnyMethod()
           .AllowAnyHeader();
});
app.Run();
