using SharedFramework;
using Users.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddUsersModule();
builder.Services.AddSharedFramework(builder.Configuration);

var app = builder.Build();

app.UseUsersModule();
app.UseSharedFramework();

app.Run();
