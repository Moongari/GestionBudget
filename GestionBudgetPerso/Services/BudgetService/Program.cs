using BudgetService.Repositories;
using BudgetService.Data; // Assure-toi que le namespace de ApplicationDbContext est bien importé
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Ajoute les services ici
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();

    // Ajouter Swagger
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Gestion Budget API",
            Version = "v1",
            Description = "API pour la gestion du budget avec microservices",
            Contact = new OpenApiContact
            {
                Name = "MOON-LIGHT",
                Email = "moungari/moustafa@hotmail.com",
                Url = new Uri("https://github.com/Moongari")
            }
        });
    });

    // ✅ Enregistrer le DbContext pour Entity Framework Core
  
    builder.Services.AddDbContext<CompteContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("SqlliteDB")));

    // ✅ Enregistrer les repositories et services
    builder.Services.AddScoped<ICompteRepository, CompteRepository>();

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseAuthorization();
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Erreur au démarrage de l'application : {ex.Message}");
    throw;
}
