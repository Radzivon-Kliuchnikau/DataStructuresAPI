using Data_Structures_Implementations_API.Data;
using Data_Structures_Implementations_API.Repository;
using Data_Structures_Implementations_API.SinglyLinkedList.Interfaces;
using Data_Structures_Implementations_API.SinglyLinkedList.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<ISinglyLinkedList, SinglyLinkedList>();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseInMemoryDatabase("DataStructureImplementationsDb");
});

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();