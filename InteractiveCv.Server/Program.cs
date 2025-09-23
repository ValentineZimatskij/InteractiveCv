using Microsoft.EntityFrameworkCore;
using InteractiveCv.Server.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.MapFallbackToFile("/index.html");

// Эндпоинт для ручной инициализации БД
app.MapGet("/api/init-db", async (ApplicationDbContext dbContext) =>
{
    try
    {
        await dbContext.Database.MigrateAsync();
        return Results.Ok("Database migrated successfully!");
    }
    catch (Exception ex)
    {
        return Results.Problem($"Migration failed: {ex.Message}");
    }
});

// Автоматическая инициализация БД при запуске
app.Lifetime.ApplicationStarted.Register(async () =>
{
    try
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        app.Logger.LogInformation("Checking database connection...");

        // Ждем доступности БД
        for (int i = 0; i < 10; i++)
        {
            if (await dbContext.Database.CanConnectAsync())
            {
                app.Logger.LogInformation("Database connection established!");
                break;
            }
            app.Logger.LogInformation("Waiting for database...");
            await Task.Delay(1000);
        }

        // Применяем миграции
        await dbContext.Database.MigrateAsync();
        app.Logger.LogInformation("Database migrations applied successfully!");
    }
    catch (Exception ex)
    {
        app.Logger.LogError(ex, "An error occurred while initializing database");
    }
});

app.Run();