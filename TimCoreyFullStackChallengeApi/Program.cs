using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.Configuration;

var builder = WebApplication.CreateBuilder(args);

string connectionStr = builder.Configuration.GetConnectionString("main")
    ?? throw new InvalidConfigurationException("Connection string is missing from the configuration.json file.");

builder.Services.AddSqlServer<EmployeeDb>(connectionString: connectionStr);
builder.Services.AddOpenApi();

const string corsPolicyName = "_corsAllowLocalhost";
builder.Services.AddCors(options =>
{
    options.AddPolicy(corsPolicyName, policy => {
        policy.SetIsOriginAllowed(origin => new Uri(origin).IsLoopback);
        policy.WithMethods("GET");
    });
});

var app = builder.Build();
app.UseCors(corsPolicyName);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", async (EmployeeDb db) =>
{
    var employees = await db.Employees.ToListAsync();
    return Results.Ok(employees);
});

app.Run();