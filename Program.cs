using estudos_crud.Data;
using estudos_crud.middlewares;
using estudos_crud.Repository;
using estudos_crud.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connectDatabase = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<UserContext>(options =>
{
  options.UseMySql(connectDatabase,
  ServerVersion.AutoDetect(connectDatabase));
});

builder.Services.AddScoped<IUserCarService, UserCarService>();
builder.Services.AddScoped<IUserCarRepository, UserCarRepository>();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseMiddleware(typeof(BadRequest));
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseAuthorization();
app.MapControllers();
app.Run();
